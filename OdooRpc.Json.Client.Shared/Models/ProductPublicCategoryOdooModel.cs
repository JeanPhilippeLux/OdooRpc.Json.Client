using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>product.public.category</c> — catégorie de produit du site web.
    /// Structure hiérarchique via <see cref="ParentId"/>. Référencée depuis
    /// <c>product.template.public_categ_ids</c> (many2many).
    /// </summary>
    [OdooTableName("product.public.category")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductPublicCategoryOdooModel : OdooModelBase
    {
        /// <summary>Nom affiché de la catégorie.</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>ID de la catégorie parente (null/0 pour une racine).</summary>
        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        /// <summary>Ordre d'affichage parmi les frères/sœurs.</summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>Identifiant du site web (null = applicable à tous les sites).</summary>
        [JsonProperty("website_id")]
        public long? WebsiteId { get; set; }
    }
}
