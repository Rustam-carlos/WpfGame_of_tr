using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGame_of_tr.Object
{
    public class Response
    {

        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("book")]
        public IList<Book> Book { get; set; }

        [JsonProperty("show")]
        public IList<Show> Show { get; set; }
    }
}
