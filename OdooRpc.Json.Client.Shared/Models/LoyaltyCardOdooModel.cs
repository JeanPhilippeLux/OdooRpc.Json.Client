using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("loyalty.card")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class LoyaltyCardOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        [JsonProperty("program_id")]
        public long? ProgramId { get; set; }

        [JsonProperty("points")]
        public double? Points { get; set; }

        [JsonProperty("points_display")]
        public string PointsDisplay { get; set; }

        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }
    }
}
