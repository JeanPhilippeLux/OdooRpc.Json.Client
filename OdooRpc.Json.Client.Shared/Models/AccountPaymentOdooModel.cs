using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;


namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("account.payment")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountPaymentOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("payment_method_line_id")]
        public long PaymentMethodLineId {  get; set; }
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }
        [JsonProperty("date")]
        public DateTime? Date { get; set; }
        [JsonProperty("payment_type")]
        public PaymentTypeOdooEnum PaymentType { get; set; }
        [JsonProperty("journal_id")]
        public long JournalId { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTypeOdooEnum
    {
        [EnumMember(Value = "outbound")]
        Outbound = 1,
        [EnumMember(Value = "inbound")]
        Inbound = 2,
    }
}
