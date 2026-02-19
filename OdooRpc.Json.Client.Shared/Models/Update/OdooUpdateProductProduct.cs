using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooRpc.Json.Client.Shared.Models.Create
{
    [OdooTableName("product.product")]
    public class OdooUpdateProductProduct : IOdooCreateModel
    {
        [JsonProperty("intrastat_code_id")]
        public int IntrastatCodeId { get; set; }
        [JsonProperty("intrastat_origin_country_id")]
        public long IntrastatOriginCountryId { get; set; }

        [JsonProperty("weight")]
        public decimal Weight { get; set; }

        [JsonProperty("default_code")]
        public string DefaultCode { get; set; }

    }
}
