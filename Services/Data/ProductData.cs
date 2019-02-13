using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Data
{
    public class ProductData
    {
        public ProductData()
        {
            Associado = true;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "associated")]
        public bool Associado { get; set; }
    }
}
