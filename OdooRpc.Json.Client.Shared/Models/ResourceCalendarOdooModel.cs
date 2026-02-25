using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("resource.calendar")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResourceCalendarOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // one2many vers resource.calendar.attendance
        [JsonProperty("attendance_ids")]
        public long[] AttendanceIds { get; set; }

        // timezone
        [JsonProperty("tz")]
        public string Tz { get; set; }
    }
}
