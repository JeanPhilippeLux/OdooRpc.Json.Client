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
    [OdooTableName("account.move.line")]
    public class OdooAccountMoveLineUpdate : IOdooCreateModel
    {
        [JsonProperty("has_price_changed")]
        public bool? HasPriceChanged { get; set; }
    }
}
