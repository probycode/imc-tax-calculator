using IMC.Common.Interfaces;
using IMC.TaxJar.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Requests
{
    public class TaxForOrderRequest
    {
        #region To
        [JsonProperty("to_country")]
        public string ToCountry { get; set; }

        [JsonProperty("to_zip")]
        public string ToZip { get; set; }

        [JsonProperty("to_state")]
        public string ToState { get; set; }

        [JsonProperty("to_city")]
        public string ToCity { get; set; }

        [JsonProperty("to_street")]
        public string ToStreet { get; set; }
        #endregion

        #region From
        [JsonProperty("from_country")]
        public string FromCountry { get; set; }

        [JsonProperty("from_zip")]
        public string FromZip { get; set; }

        [JsonProperty("from_state")]
        public string FromState { get; set; }

        [JsonProperty("from_city")]
        public string FromCity { get; set; }

        [JsonProperty("from_street")]
        public string FromStreet { get; set; }
        #endregion

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("nexus_addresses")]
        public NexusAddress[] NexusAddress { get; set; }

        [JsonProperty("line_items")]
        public LineItemIn[] LineItem { get; set; }
    }
}
