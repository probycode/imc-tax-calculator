using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Models
{
    public class NexusAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("Zip")]
        public string zip { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }
    }
}
