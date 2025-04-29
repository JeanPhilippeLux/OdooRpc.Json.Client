using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("uom.uom")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class UomUomOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category_id")]
        public long CategoryId { get; set; }

        [JsonProperty("id_letstart_id")]
        public long IdLetstartId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("factor")]
        public double Factor { get; set; }

        /// <summary>
        /// uom_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("uom_type")]
        public TypeUomUomOdooEnum UomType { get; set; }

    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeUomUomOdooEnum
    {
        [EnumMember(Value = "bigger")]
        BiggerThanTheReferenceUnitOfMeasure = 1,

        [EnumMember(Value = "reference")]
        ReferenceUnitOfMeasureForThisCategory = 2,

        [EnumMember(Value = "smaller")]
        SmallerThanTheReferenceUnitOfMeasure = 3,
    }
}
