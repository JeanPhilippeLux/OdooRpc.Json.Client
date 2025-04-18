using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("stock.picking")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class StockPickingOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
