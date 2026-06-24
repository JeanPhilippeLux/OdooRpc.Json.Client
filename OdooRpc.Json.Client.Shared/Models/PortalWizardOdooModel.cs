using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Wizard transient Odoo "Donner accès au portail" (modèle <c>portal.wizard</c>).
    /// On le crée avec un contexte <c>active_model=res.partner</c> + <c>active_ids=[partnerId]</c>
    /// puis on lit ses lignes <see cref="PortalWizardUserOdooModel"/> (user_ids) pour appeler
    /// <c>action_grant_access</c> sur la ligne correspondant au contact à inviter.
    /// </summary>
    [OdooTableName("portal.wizard")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PortalWizardOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // portal.wizard.user (one2many) : une ligne par contact ayant une adresse e-mail.
        [JsonProperty("user_ids")]
        public long[] UserIds { get; set; }

        [JsonProperty("welcome_message")]
        public string WelcomeMessage { get; set; }
    }
}
