using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>product.tag</c> — étiquettes / tags produits.
    /// Référencé depuis <c>product.template.product_tag_ids</c> (many2many).
    /// Le flag <c>visible_on_ecommerce</c> détermine si le tag est affiché sur la
    /// fiche produit côté site web.
    /// </summary>
    [OdooTableName("product.tag")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTagOdooModel : OdooModelBase
    {
        /// <summary>Nom affiché du tag (requis).</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>True pour afficher le tag sur la fiche produit du site web.</summary>
        [JsonProperty("visible_on_ecommerce")]
        public bool? VisibleOnECommerce { get; set; }

        /// <summary>
        /// Catégorie d'étiquettes de produit (<c>product.tag.category</c>) à laquelle
        /// appartient ce tag (many2one). null/0 = aucune catégorie.
        /// </summary>
        [JsonProperty("product_tag_category_id")]
        public long? ProductTagCategoryId { get; set; }

        /// <summary>Couleur (entier symbolisant la teinte côté UI Odoo).</summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>Ordre d'affichage parmi les tags.</summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>Templates de produit utilisant ce tag (many2many).</summary>
        [JsonProperty("product_template_ids")]
        public long[] ProductTemplateIds { get; set; }
    }
}
