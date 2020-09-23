using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Models
{
    public class Tax
    {
        [JsonProperty("order_total_amount")]
        public string OrderTotalAmount { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("taxable_amount")]
        public string TaxableAmount { get; set; }

        [JsonProperty("amount_to_collect")]
        public string AmountToCollect { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("has_nexus")]
        public string HasNexus { get; set; }

        [JsonProperty("freight_taxable")]
        public string FreightTaxable { get; set; }

        [JsonProperty("tax_source")]
        public string TaxSource { get; set; }

        [JsonProperty("jurisdictions")]
        public Jurisdictions Jurisdictions { get; set; }

        [JsonProperty("breakdown")]
        public Breakdown Breakdown { get; set; }
    }
}
