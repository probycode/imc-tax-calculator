using IMC.TaxJar.Client.Models;
using Newtonsoft.Json;

namespace IMC.TaxJar.Client.Responses
{
    public class RatesForLocationResponse
    {
        [JsonProperty("rate")]
        public Rate Rate { get; set; }
    }
}
