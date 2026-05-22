using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>sync.stock.tartes.francoise</c> — ligne de stock disponible par couple
    /// (produit × entrepôt). Alimenté par Lets.TART via la synchro temps réel (mode "Odoo")
    /// pour exposer les quantités vendables aux canaux e-commerce / POS Odoo sans passer
    /// par stock.quant.
    /// </summary>
    [OdooTableName("sync.stock.tartes.francoise")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class SyncStockTartesFrancoiseOdooModel : OdooModelBase
    {
        /// <summary>product.product (variante). Many2one requis.</summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        /// <summary>stock.warehouse. Many2one requis.</summary>
        [JsonProperty("warehouse_id")]
        public long WarehouseId { get; set; }

        /// <summary>Quantité disponible (entier). Peut être négative en théorie, plafonnée à 0 côté Lets.TART.</summary>
        [JsonProperty("qty")]
        public int Qty { get; set; }
    }
}
