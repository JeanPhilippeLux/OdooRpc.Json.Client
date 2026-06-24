using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Ligne du wizard portail (modèle <c>portal.wizard.user</c>) : un contact candidat à l'accès portail.
    /// L'action <c>action_grant_access</c> appelée sur l'id de cette ligne crée/active le res.users portail
    /// et envoie le mail d'invitation. C'est l'équivalent du bouton "Accorder l'accès" de l'UI Odoo.
    /// </summary>
    [OdooTableName("portal.wizard.user")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PortalWizardUserOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // res.partner lié à cette ligne.
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        // true si le contact a déjà un accès portail actif.
        [JsonProperty("in_portal")]
        public bool InPortal { get; set; }
    }
}
