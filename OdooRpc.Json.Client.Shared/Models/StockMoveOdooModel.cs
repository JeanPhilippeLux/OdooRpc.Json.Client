using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("stock.move")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class StockMoveOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // picking_id
        // required
        [JsonProperty("picking_id")]
        public long PickingId { get; set; }

        // group_id
        // required
        [JsonProperty("group_id")]
        public long GroupId { get; set; }


        [JsonProperty("product_uom_qty")]
        public double ProductUomQty { get; set; }

        [JsonProperty("quantity")]
        public double Quantity{ get; set; }

    }
}
