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
    [OdooTableName("product.template.attribute.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTemplateAttributeLineOdoo : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("product_tmpl_id")]
        public long ProductTemplateId { get; set; }

        [JsonProperty("attribute_id")]
        public int AttributeId { get; set; }

        [JsonProperty("value_ids")]
        public long[] ValueIds { get; set; }

    }
}
