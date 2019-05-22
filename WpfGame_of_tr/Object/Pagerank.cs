using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGame_of_tr.Object
{
    public class Pagerank
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
