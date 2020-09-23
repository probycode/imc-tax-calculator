using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.TaxJar.Client.Models
{
    public class Breakdown
    {
        [JsonProperty("taxable_amount")]
        public string TaxableAmount { get; set; }

        [JsonProperty("tax_collectable")]
        public string TaxCollectable { get; set; }

        [JsonProperty("combined_tax_rate")]
        public string CombinedTaxRate { get; set; }

        [JsonProperty("state_taxable_amount")]
        public string StateTaxableAmount { get; set; }

        [JsonProperty("state_tax_rate")]
        public string StateTaxRate { get; set; }

        [JsonProperty("state_tax_collectable")]
        public string StateTaxCollectable { get; set; }

        [JsonProperty("county_taxable_amount")]
        public string CountyTaxableAmount { get; set; }

        [JsonProperty("county_tax_rate")]
        public string CountyTaxRate { get; set; }

        [JsonProperty("county_tax_collectable")]
        public string CountyTaxCollectable { get; set; }

        [JsonProperty("city_taxable_amount")]
        public string CityTaxableAmount { get; set; }

        [JsonProperty("city_tax_rate")]
        public string CityTaxRate { get; set; }

        [JsonProperty("city_tax_collectable")]
        public string CityTaxCollectable { get; set; }

        [JsonProperty("special_district_taxable_amount")]
        public string SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public string SpecialTaxRate { get; set; }

        [JsonProperty("special_district_tax_collectable")]
        public string SpecialDistrictTaxCollectable { get; set; }

        [JsonProperty("line_items")]
        public LineItemOut[] LineItems { get; set; }
    }
}
