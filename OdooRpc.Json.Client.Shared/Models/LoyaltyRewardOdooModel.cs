using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("loyalty.reward")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class LoyaltyRewardOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        // loyalty.program
        [JsonProperty("program_id")]
        public long? ProgramId { get; set; }

        // "product" (produit offert), "discount" (remise) ou "shipping" (livraison offerte).
        [JsonProperty("reward_type")]
        public string RewardType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        // Points consommés sur la carte/le bon pour obtenir la récompense.
        [JsonProperty("required_points")]
        public double? RequiredPoints { get; set; }

        // product.product offert (reward_type = "product").
        [JsonProperty("reward_product_id")]
        public long? RewardProductId { get; set; }

        [JsonProperty("reward_product_qty")]
        public double? RewardProductQty { get; set; }
    }
}
