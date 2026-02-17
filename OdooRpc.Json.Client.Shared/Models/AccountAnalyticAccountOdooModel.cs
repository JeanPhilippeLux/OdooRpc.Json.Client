using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("account.analytic.account")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountAnalyticAccountOdooModel : OdooModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
