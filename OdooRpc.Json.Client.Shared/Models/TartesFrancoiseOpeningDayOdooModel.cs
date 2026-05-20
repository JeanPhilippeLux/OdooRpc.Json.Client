using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using System;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo custom <c>tartes.francoise.opening.day</c> — jour d'ouverture exceptionnel
    /// (par-dessus le calendrier classique). Référencé depuis <c>stock.warehouse.delivery_opened_day_ids</c>.
    /// </summary>
    [OdooTableName("tartes.francoise.opening.day")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class TartesFrancoiseOpeningDayOdooModel : OdooModelBase
    {
        /// <summary>Libellé court de la journée exceptionnelle (ex: "25/12/2026").</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Description longue (libre).</summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>Date de début de la journée exceptionnelle (requis).</summary>
        [JsonProperty("opening_day")]
        public DateTime OpeningDay { get; set; }

        /// <summary>Date de fin de la journée exceptionnelle (requis).</summary>
        [JsonProperty("opening_day_end")]
        public DateTime OpeningDayEnd { get; set; }

        /// <summary>Calendrier d'horaires applicable à cette journée (many2one vers
        /// <c>resource.calendar</c>). Pilote les créneaux matin/après-midi.</summary>
        [JsonProperty("opening_hours_id")]
        public long? OpeningHoursId { get; set; }
    }
}
