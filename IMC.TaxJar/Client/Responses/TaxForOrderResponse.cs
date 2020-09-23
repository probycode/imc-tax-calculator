using IMC.TaxJar.Client.Models;
using Newtonsoft.Json;

namespace IMC.TaxJar.Client.Responses
{
    public partial class TaxForOrderResponse
    {
        [JsonProperty("tax")]
        public Tax Tax { get; set; }
    }
}
