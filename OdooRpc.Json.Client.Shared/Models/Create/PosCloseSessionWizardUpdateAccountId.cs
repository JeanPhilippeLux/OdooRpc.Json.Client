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
    [OdooTableName("pos.close.session.wizard")]
    public class PosCloseSessionWizardUpdateAccountId : IOdooCreateModel
    {
        [JsonProperty("account_id")]
        public long account_id { get; set; }
    }
}
