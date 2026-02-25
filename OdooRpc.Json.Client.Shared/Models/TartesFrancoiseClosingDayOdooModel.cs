using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("tartes.francoise.closing.day")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class TartesFrancoiseClosingDayOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // required, date
        [JsonProperty("closing_day")]
        public DateTime ClosingDay { get; set; }

        // char
        [JsonProperty("name")]
        public string Name { get; set; }

        // char, readonly
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
