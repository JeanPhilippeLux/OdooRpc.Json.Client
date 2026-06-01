using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Models;
using System;

namespace OdooRpc.Json.Client.Shared.Models.Create
{
    /// <summary>
    /// Mise à jour de la date de livraison souhaitée (commitment_date) d'une sale.order.
    /// </summary>
    [OdooTableName("sale.order")]
    public class OdooUpdateCommitmentDateSalesOrder : IOdooCreateModel
    {
        [JsonProperty("commitment_date")]
        public DateTime CommitmentDate { get; set; }
    }
}
