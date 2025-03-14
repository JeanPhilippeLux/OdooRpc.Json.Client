using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;


namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("account.bank.statement.line")]
    [JsonConverter(typeof(OdooModelConverter))]

    public class AccountBankStatementLineOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("pos_session_id")]
        public long POSSessionId { get; set; }
        [JsonProperty("journal_id")]
        public long JournalId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("payment_ref")]
        public string PaymentRef { get; set; }
        
        
    }
}
