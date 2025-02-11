using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models.Create
{
    [OdooTableName("coupon.program")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class OdooVoucherCreateOrUpdate : IOdooCreateModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("promo_code")]
        public string PromoCode { get; set; }
        [JsonProperty("rule_date_to")]
        public DateTime? RuleDateTo { get; set; }
        [JsonProperty("program_type")]
        public string ProgramType { get; set; }
        [JsonProperty("discount_fixed_amount")]
        public double DiscountFixedAmount { get; set; }
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }
    }
}