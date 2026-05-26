using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("pos.order.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class POSOderLineOdooModel : IOdooModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("order_id")]
        public int OrderID { get; set; }
        [JsonProperty("price_subtotal")]
        public decimal PriceSubTotal { get; set; }
        [JsonProperty("price_subtotal_incl")]
        public decimal PriceSubTotalIncl { get; set; }
        [JsonProperty("product_id")]
        public long ProductId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("qty")]
        public double? Qty { get; set; }

        [JsonProperty("price_unit")]
        public double PriceUnit { get; set; }
        [JsonProperty("discount")]
        public double? Discount { get; set; }
        [JsonProperty("tax_ids")]
        public long[] TaxIds { get; set; }
        [JsonProperty("analytic_distribution")]
        public Dictionary<string, double> AnalyticDistribution { get; set; }
        [JsonProperty("customer_note")]
        public string CustomerNote { get; set; }

        /// <summary>
        /// sale.order — lien vers la sale.order originale (champ custom Lets.TART côté Odoo).
        /// Renseigné quand le ticket POS clôture une commande e-commerce (la SalesTable porte
        /// alors un WebReference correspondant à sale.order.name).
        /// </summary>
        [JsonProperty("sale_order_origin_id")]
        public long? SaleOrderOriginId { get; set; }

        /// <summary>
        /// sale.order.line — lien vers la ligne d'origine de la sale.order (champ custom Lets.TART).
        /// Renseigné quand la ligne POS reprend une ligne existante de la commande e-commerce.
        /// Pour les lignes de "différence" (qty négative d'annulation + ligne corrigée), seul
        /// SaleOrderOriginId est rempli.
        /// </summary>
        [JsonProperty("sale_order_line_id")]
        public long? SaleOrderLineId { get; set; }
    }
}
