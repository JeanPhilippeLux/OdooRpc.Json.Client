using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("account.analytic.account")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountAnalyticAccountOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
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
