﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Models
{
    public class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }
    }
}
