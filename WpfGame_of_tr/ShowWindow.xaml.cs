using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfGame_of_tr.Object;

namespace WpfGame_of_tr
{
    /// <summary>
    /// Логика взаимодействия для ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        //private Show character;

        public ShowWindow(Show character)
        {
            InitializeComponent();
            string url = character.Image;
            Image1.Source = new BitmapImage(new Uri(url));
            TextBox2.Text = character.Name;
            TextBox3.Text = character.Age.AgeCount.ToString();
            TextBox4.Text = character.Gender;
            TextBox5.Text = character.Actor;
            TextBox6.Text = character.Pagerank.Title;
            TextBox7.Text = character.Father;
            TextBox8.Text = character.Mother;
            TextBox9.Text = character.House;


        }




    }
}
