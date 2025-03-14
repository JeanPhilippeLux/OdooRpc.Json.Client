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
    [OdooTableName("pos.order")]
    public class POSOrderUpdateStatus : IOdooCreateModel
    {
        [JsonProperty("state")]
        public POSStatusOdooEnum? State { get; set; }
    }
}
