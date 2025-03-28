using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("account.batch.payment")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountBatchPaymentOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("journal_id")]
        public long JournalId { get; set; }

        [JsonProperty("payment_method_id")]
        public long PaymentMethodId { get; set; }
        [JsonProperty("batch_type")]
        public PaymentTypeOdooEnum BatchType { get; set; }
        [JsonProperty("date")]
        public DateTime? Date { get; set; }
        [JsonProperty("payment_ids")]
        public long[] PaymentIds { get; set; }

    }
}
