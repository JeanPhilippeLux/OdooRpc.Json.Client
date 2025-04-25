using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;



namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("product.packaging")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductPackagingOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // product.product
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("qty")]
        public double? Qty { get; set; }

        [JsonProperty("sales")]
        public bool? Sales { get; set; }

        [JsonProperty("purchase")]
        public bool? Purchase { get; set; }
    }
}
