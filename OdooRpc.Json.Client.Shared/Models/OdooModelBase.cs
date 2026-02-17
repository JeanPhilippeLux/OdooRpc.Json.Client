using Newtonsoft.Json;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    public abstract class OdooModelBase : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("xml_id")]
        public string XmlId { get; set; }
    }
}
