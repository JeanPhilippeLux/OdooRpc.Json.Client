using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("pos.order.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class POSOderLineOdooModel : IOdooModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("order_id")]
        public int OrderID { get; set; }
        [JsonProperty("price_subtotal")]
        public decimal PriceSubTotal { get; set; }
        [JsonProperty("price_subtotal_incl")]
        public decimal PriceSubTotalIncl { get; set; }
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("qty")]
        public double? Qty { get; set; }

        [JsonProperty("price_unit")]
        public double PriceUnit { get; set; }
        [JsonProperty("discount")]
        public double? Discount { get; set; }
        [JsonProperty("tax_ids")]
        public long[] TaxIds { get; set; }

    }
}
