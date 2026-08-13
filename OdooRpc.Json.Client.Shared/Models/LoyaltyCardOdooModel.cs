using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("loyalty.card")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class LoyaltyCardOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        [JsonProperty("program_id")]
        public long? ProgramId { get; set; }

        [JsonProperty("points")]
        public double? Points { get; set; }

        [JsonProperty("points_display")]
        public string PointsDisplay { get; set; }

        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// Carte active. LECTURE SEULE : côté Odoo c'est un champ calculé et stocké
        /// (depends: program_type, partner_id, partner_id.is_opt_in_fidelity). Une écriture est
        /// acceptée en apparence (le write renvoie true) mais n'est PAS appliquée.
        ///
        /// Pour neutraliser une carte (ex. fusion de comptes), détacher son partner
        /// (partner_id = false) — c'est ce qui la sort du champ calculé `card_number` du module
        /// custom, lequel ne filtre de toute façon pas sur `active`.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }
    }
}
