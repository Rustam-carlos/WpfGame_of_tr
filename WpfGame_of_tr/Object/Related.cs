using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGame_of_tr.Object
{
    public class Related
    {

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("img")]
        public bool Img { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("mentions")]
        public int Mentions { get; set; }
    }
}
