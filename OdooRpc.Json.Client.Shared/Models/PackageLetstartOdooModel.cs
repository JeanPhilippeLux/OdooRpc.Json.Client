using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;


namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("package.letstart")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PackageLetstartOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id_letstart")]
        public long IdLetstart { get; set; }
    }
}
