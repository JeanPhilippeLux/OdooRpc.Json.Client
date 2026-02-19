using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooRpc.Json.Client.Shared.Models
{

    
    [OdooTableName("product.template.attribute.value")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTemplateAttributeValueOdoo : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("attribute_id")]
        public long AttributeId { get; set; }
        [JsonProperty("attribute_line_id")]
        public long AttributeLineId { get; set; }
        [JsonProperty("product_attribute_value_id")]
        public long ProductAttributeValueId { get; set; }

        [JsonProperty("price_extra")]
        public double PriceExtra { get; set; }

    }
}
