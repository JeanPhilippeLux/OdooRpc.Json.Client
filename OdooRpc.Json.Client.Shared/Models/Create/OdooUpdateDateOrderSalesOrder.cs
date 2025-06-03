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
    [OdooTableName("sale.order")]
    public class OdooUpdateDateOrderSalesOrder : IOdooCreateModel
    {
        [JsonProperty("date_order")]
        public DateTime DateOrder { get; set; }
    }
}
