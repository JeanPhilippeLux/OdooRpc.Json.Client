using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using System;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>resource.calendar.leaves</c> — congé ou jour de fermeture lié à un
    /// <c>resource.calendar</c>. Utilisé pour exclure des plages horaires de l'agenda
    /// (vacances, jours fériés, fermetures exceptionnelles).
    /// </summary>
    [OdooTableName("resource.calendar.leaves")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResourceCalendarLeavesOdooModel : OdooModelBase
    {
        /// <summary>Libellé du congé (ex: "25/12/2026 - Noël").</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Calendrier auquel ce congé s'applique (many2one vers <c>resource.calendar</c>).
        /// Si null → s'applique à tous les calendriers de la company.</summary>
        [JsonProperty("calendar_id")]
        public long? CalendarId { get; set; }

        /// <summary>Société (many2one vers <c>res.company</c>).</summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>Datetime de début du congé.</summary>
        [JsonProperty("date_from")]
        public DateTime DateFrom { get; set; }

        /// <summary>Datetime de fin du congé.</summary>
        [JsonProperty("date_to")]
        public DateTime DateTo { get; set; }
    }
}
