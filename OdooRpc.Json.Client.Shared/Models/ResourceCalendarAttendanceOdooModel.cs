using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("resource.calendar.attendance")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResourceCalendarAttendanceOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        // selection 0-6 (Monday=0 ... Sunday=6 dans Odoo)
        [JsonProperty("dayofweek")]
        public DayOfWeekOdooEnum DayOfWeek { get; set; }

        // float : heure de début (ex: 8.0 = 08:00, 8.5 = 08:30)
        [JsonProperty("hour_from")]
        public double HourFrom { get; set; }

        // float : heure de fin
        [JsonProperty("hour_to")]
        public double HourTo { get; set; }

        // resource.calendar
        [JsonProperty("calendar_id")]
        public long CalendarId { get; set; }

        // selection: morning/afternoon
        [JsonProperty("day_period")]
        public DayPeriodOdooEnum DayPeriod { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeekOdooEnum
    {
        [EnumMember(Value = "0")]
        Monday = 0,

        [EnumMember(Value = "1")]
        Tuesday = 1,

        [EnumMember(Value = "2")]
        Wednesday = 2,

        [EnumMember(Value = "3")]
        Thursday = 3,

        [EnumMember(Value = "4")]
        Friday = 4,

        [EnumMember(Value = "5")]
        Saturday = 5,

        [EnumMember(Value = "6")]
        Sunday = 6,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayPeriodOdooEnum
    {
        [EnumMember(Value = "morning")]
        Morning = 1,

        [EnumMember(Value = "afternoon")]
        Afternoon = 2,
    }
}
