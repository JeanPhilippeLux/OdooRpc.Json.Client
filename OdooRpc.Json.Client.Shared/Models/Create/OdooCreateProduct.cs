using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models.Create
{
    [OdooTableName("product.product")]
    public class OdooCreateProduct : IOdooCreateModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uom_id")]
        public int UomId { get; set; }

        [JsonProperty("uom_po_id")]
        public int UomPoId { get; set; }

    }
}