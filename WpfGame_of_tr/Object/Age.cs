using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGame_of_tr.Object
{
    public class Age
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int AgeCount { get; set; }
    }
}
