using IMC.Common.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Requests
{
    public class RatesForLocationRequest
    {
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        private RatesForLocationRequest() {}

        public RatesForLocationRequest(string zip)
        {
            Zip = zip;
        }
    }
}
