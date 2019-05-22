using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfGame_of_tr.Object;

namespace WpfGame_of_tr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string answer = string.Empty;
            WebClient client = new WebClient();
          


            string url = "https://" + "api.got.show/api/general/characters";

            using (Stream stream = client.OpenRead(url))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    answer = reader.ReadToEnd();
                }
            }
            Response response = JsonConvert.DeserializeObject<Object.Response>(answer);

            List<Show> Heroy = new List<Show>();
            foreach (var i in response.Show)
            {
                Heroy.Add(i);
            }
            
            List1.ItemsSource = response.Show;
            CollectionView collection = (CollectionView)CollectionViewSource.GetDefaultView(List1.ItemsSource);
            collection.Filter = FilterResults;

            //TextBox1.Text = Heroy[0].Actor;
        }

        private bool FilterResults(object Item)
        {
            if (string.IsNullOrEmpty(TextBox1.Text))
                return true;
            else
                return ((Item as Show).Name.IndexOf(TextBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(List1.ItemsSource).Refresh();
        }
       
        private void List1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var character = (Show)List1.SelectedItem;

            var info = new ShowWindow(character);
            info.Show();
        }
    }
}
