using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    
    [OdooTableName("pos.payment")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class POSPaymentOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }
        [JsonProperty("payment_date")]
        public DateTime PaymentDate { get; set; }
        [JsonProperty("payment_method_id")]
        public long PaymentMethodId { get; set; }

        [JsonProperty("pos_order_id")]
        public long POSOrderId { get; set; }


    }

    

}
