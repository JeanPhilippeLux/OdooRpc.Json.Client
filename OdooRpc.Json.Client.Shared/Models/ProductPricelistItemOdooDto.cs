using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo pour product.pricelist.item
    /// Représente une règle de prix dans une liste de prix Odoo.
    /// </summary>
    [OdooTableName("product.pricelist.item")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductPricelistItemOdooDto : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID de la liste de prix parente
        /// </summary>
        [JsonProperty("pricelist_id")]
        public long PricelistId { get; set; }

        /// <summary>
        /// "3_global" (tous les produits), "2_product_category" (catégorie), "1_product" (variante), "0_product_variant" (variante spécifique)
        /// </summary>
        [JsonProperty("applied_on")]
        public string AppliedOn { get; set; }

        /// <summary>
        /// product.product — variante spécifique (si applied_on = "0_product_variant")
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// product.template — produit (si applied_on = "1_product")
        /// </summary>
        [JsonProperty("product_tmpl_id")]
        public long? ProductTmplId { get; set; }

        /// <summary>
        /// product.category — catégorie de produit (si applied_on = "2_product_category")
        /// </summary>
        [JsonProperty("categ_id")]
        public long? CategId { get; set; }

        /// <summary>
        /// Quantité minimum pour appliquer cette règle
        /// </summary>
        [JsonProperty("min_quantity")]
        public decimal MinQuantity { get; set; }

        /// <summary>
        /// "list_price" (prix public), "standard_price" (coût), "pricelist" (autre liste), "percentage" (remise %)
        /// </summary>
        [JsonProperty("compute_price")]
        public string ComputePrice { get; set; }

        /// <summary>
        /// Prix fixe (si compute_price = "fixed")
        /// </summary>
        [JsonProperty("fixed_price")]
        public decimal? FixedPrice { get; set; }

        /// <summary>
        /// Pourcentage de remise (si compute_price = "percentage" ou "formula")
        /// </summary>
        [JsonProperty("percent_price")]
        public decimal? PercentPrice { get; set; }

        /// <summary>
        /// Liste de prix de base (si compute_price = "formula" ou "percentage")
        /// </summary>
        [JsonProperty("base_pricelist_id")]
        public long? BasePricelistId { get; set; }

        /// <summary>
        /// Base de calcul pour les formules : "list_price", "standard_price", "pricelist"
        /// </summary>
        [JsonProperty("base")]
        public string Base { get; set; }

        /// <summary>
        /// Date de début de validité
        /// </summary>
        [JsonProperty("date_start")]
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// Date de fin de validité
        /// </summary>
        [JsonProperty("date_end")]
        public DateTime? DateEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
