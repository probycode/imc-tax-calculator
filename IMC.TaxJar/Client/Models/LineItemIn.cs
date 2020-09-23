using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Models
{
    public class LineItemIn
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("quantity ")]
        public string Auantity { get; set; }

        [JsonProperty("product_tax_code")]
        public string ProductTaxCode { get; set; }

        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }

        [JsonProperty("discount ")]
        public string Discount { get; set; }
    }
}
