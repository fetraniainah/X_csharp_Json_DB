using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC3.Model
{
    public  class Category
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Categorie { get; set; }

    }
}
