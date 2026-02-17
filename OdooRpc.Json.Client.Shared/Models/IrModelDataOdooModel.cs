using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("ir.model.data")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class IrModelDataOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("module")]
        public string Module { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("res_id")]
        public long ResId { get; set; }

        [JsonProperty("complete_name")]
        public string CompleteName { get; set; }
    }
}
