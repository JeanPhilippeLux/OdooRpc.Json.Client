using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("pos.order")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class POSOrderOdooModel : IOdooModel
    {
        [JsonProperty("session_id")]
        public long POSSessionId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }
        [JsonProperty("amount_total")]
        public double AmountTotal { get; set; }
        [JsonProperty("amount_tax")]
        public double AmountTax { get; set; }
        [JsonProperty("amount_return")]
        public double AmountReturn { get; set; }
        [JsonProperty("amount_paid")]
        public double AmountPaid { get; set; }
        [JsonProperty("config_id")]
        public long ConfigId { get; set; }

        [JsonProperty("lines")]
        public long[] Lines { get; set; }

        [JsonProperty("payment_ids")]
        public long[] PaymentIds { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("state")]
        public POSStatusOdooEnum? State { get; set; }
        [JsonProperty("tracking_number")]
        public string TrackingNumber  { get; set; }
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }
        [JsonProperty("pos_reference")]
        public string POSReference { get; set; }
        [JsonProperty("ticket_code")]
        public string TicketCode { get; set; }

        [JsonProperty("date_order")]
        public DateTime DateOrder { get; set; }
    }


    [JsonConverter(typeof(StringEnumConverter))]
    public enum POSStatusOdooEnum
    {
        [EnumMember(Value = "draft")]
        New = 1,

        [EnumMember(Value = "cancel")]
        Cancel = 2,

        [EnumMember(Value = "paid")]
        Paid = 3,

        [EnumMember(Value = "done")]
        Done = 4,

        [EnumMember(Value = "invoiced")]
        Invoiced = 5,
    }
}
