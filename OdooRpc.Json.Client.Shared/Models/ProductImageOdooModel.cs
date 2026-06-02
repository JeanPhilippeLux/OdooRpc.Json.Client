using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>product.image</c> — images additionnelles (galerie) attachées
    /// à un <c>product.template</c>. L'image principale du template reste stockée
    /// directement dans <c>product.template.image_1920</c>.
    /// </summary>
    [OdooTableName("product.image")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductImageOdooModel : OdooModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_1920")]
        public string Image1920 { get; set; }

        [JsonProperty("product_tmpl_id")]
        public long? ProductTemplateId { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }
    }
}
