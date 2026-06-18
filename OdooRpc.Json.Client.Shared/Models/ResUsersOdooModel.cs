using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("res.users")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResUsersOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // Identifiant de connexion (généralement l'email).
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        // res.partner lié (many2one).
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // Site web par défaut (many2one) — B2B.
        [JsonProperty("website_id")]
        public long? WebsiteId { get; set; }

        // Société (many2one).
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // Sociétés autorisées (many2many).
        [JsonProperty("company_ids")]
        public long[] CompanyIds { get; set; }

        // Groupes de sécurité (many2many) — pour ajouter le groupe Portal.
        [JsonProperty("groups_id")]
        public long[] GroupsId { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        // True quand l'utilisateur est un compte "partagé" (portal / public).
        [JsonProperty("share")]
        public bool? Share { get; set; }
    }
}
