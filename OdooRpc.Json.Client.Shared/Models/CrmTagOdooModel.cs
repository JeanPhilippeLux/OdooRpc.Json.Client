using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>crm.tag</c> — étiquettes utilisées par <c>sale.order.tag_ids</c>.
    /// Lets.TART y pousse un tag "Importé Lets.TART" pour marquer les commandes e-commerce
    /// déjà rapatriées dans le POS et éviter les doublons à la prochaine synchro.
    /// </summary>
    [OdooTableName("crm.tag")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class CrmTagOdooModel : OdooModelBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public int? Color { get; set; }
    }
}
