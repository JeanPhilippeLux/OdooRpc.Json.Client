using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("pos.session")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class POSSessionOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("config_id")]
        public long ConfigId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("state")]
        public POSSessionOdooState State { get; set; }


        [JsonProperty("start_at")]
        public DateTime StartAt { get; set; }


    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum POSSessionOdooState : int
    {
        [EnumMember(Value = "opening_control")]
        OpeningControl = 1,
        [EnumMember(Value = "opened")]
        Opened = 2,
        [EnumMember(Value = "closing_control")]
        ClosingControl = 3,
        [EnumMember(Value = "closed")]
        Closed = 4,

    }


}
