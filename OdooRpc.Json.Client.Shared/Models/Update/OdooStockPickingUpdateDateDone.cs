using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooRpc.Json.Client.Shared.Models.Update
{
    [OdooTableName("stock.picking")]
    public class OdooStockPickingUpdateDateDone : IOdooCreateModel
    {
        [JsonProperty("date_done")]
        public DateTime DateDone { get; set; }
    }
}
