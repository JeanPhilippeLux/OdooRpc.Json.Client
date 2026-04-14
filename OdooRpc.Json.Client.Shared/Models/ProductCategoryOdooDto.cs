using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo pour product.category (catégorie interne de produit).
    /// Utilisé pour mapper les InventTariffGroup de Let's TART vers Odoo.
    /// Le champ categ_id sur product.template référence cette table.
    /// </summary>
    [OdooTableName("product.category")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductCategoryOdooDto : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Catégorie parente (0 ou null = racine)
        /// </summary>
        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        [JsonProperty("complete_name")]
        public string CompleteName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
