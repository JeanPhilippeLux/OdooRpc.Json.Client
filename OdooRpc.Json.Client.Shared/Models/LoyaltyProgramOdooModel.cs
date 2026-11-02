using System;
using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("loyalty.program")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class LoyaltyProgramOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("program_type")]
        public string ProgramType { get; set; }

        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // Période de validité du programme (vides = pas de limite).
        [JsonProperty("date_from")]
        public DateTime? DateFrom { get; set; }

        [JsonProperty("date_to")]
        public DateTime? DateTo { get; set; }

        // loyalty.reward
        [JsonProperty("reward_ids")]
        public long[] RewardIds { get; set; }
    }
}
