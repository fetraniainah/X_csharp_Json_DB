using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC3.Model
{
    public class Produit
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("stock")]
        public int stock { get; set; }

        [JsonProperty("prix")]
        public double prix { get; set; }

        [JsonProperty("note")]
        public string note { get; set; }
        [JsonProperty("categories")] public string categories { get; set; }

        
    }
}
