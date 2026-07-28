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
        // Le champ Odoo s'appelle bien "is_portal" (et non "in_portal") : demander "in_portal"
        // fait échouer toute la lecture avec "Invalid field 'in_portal' on model
        // 'portal.wizard.user'", donc aucune ligne du wizard n'est remontée.
        [JsonProperty("is_portal")]
        public bool IsPortal { get; set; }

        /// <summary>
        /// État de l'adresse e-mail de la ligne, calculé par Odoo : <c>ok</c> = adresse exploitable,
        /// <c>ko</c> = adresse invalide (typiquement un champ contenant plusieurs adresses).
        /// Une ligne <c>ko</c> ne peut pas recevoir d'accès portail.
        /// </summary>
        [JsonProperty("email_state")]
        public string EmailState { get; set; }
    }
}
