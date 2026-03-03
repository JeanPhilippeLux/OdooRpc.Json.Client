using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("delivery.carrier")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class DeliveryCarrierOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // selection: fixed, in_store, etc. (fournisseur/type de livraison)
        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        // many2many vers stock.warehouse (onglet "Magasins" dans Odoo)
        [JsonProperty("warehouse_ids")]
        public long[] WarehouseIds { get; set; }
    }
}
