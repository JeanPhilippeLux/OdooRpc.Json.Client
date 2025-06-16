using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("mail.activity")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class MailActivityOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("res_model")]
        public string ResModel { get; set; }
        [JsonProperty("res_model_id")]
        public long? ResModelId { get; set; }

        [JsonProperty("res_id")]
        public long? ResId { get; set; }
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }


        [JsonProperty("user_id")]
        public long? UserId { get; set; }


    }
}
