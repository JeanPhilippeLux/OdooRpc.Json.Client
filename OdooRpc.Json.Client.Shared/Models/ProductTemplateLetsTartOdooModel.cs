using Newtonsoft.Json;
using OdooRpc.Json.Client.Converters;
using System;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Extension de <see cref="ProductTemplateOdooModel"/> avec les champs custom Lets.TART
    /// présents sur le module Odoo : périodes d'achat/vente et nombre de jours avant livraison.
    /// Le décorator <c>[OdooTableName]</c> hérite de la classe de base (= "product.template").
    /// </summary>
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTemplateLetsTartOdooModel : ProductTemplateOdooModel
    {
        /// <summary>
        /// buying_period_date_start — date de début de la période où l'article peut être commandé
        /// par les ateliers à Seneffe (= SalesFrom côté Lets.TART, catalogues 12/43).
        /// </summary>
        [JsonProperty("buying_period_date_start")]
        public DateTime? BuyingPeriodDateStart { get; set; }

        /// <summary>
        /// buying_period_date_end — date de fin de la période où l'article peut être commandé
        /// par les ateliers à Seneffe (= SalesTo côté Lets.TART, catalogues 12/43).
        /// </summary>
        [JsonProperty("buying_period_date_end")]
        public DateTime? BuyingPeriodDateEnd { get; set; }

        /// <summary>
        /// publishing_period_date_start — date à partir de laquelle l'article peut être publié
        /// (site web, e-commerce). Idem que la période d'achat dans la sémantique Lets.TART.
        /// </summary>
        [JsonProperty("publishing_period_date_start")]
        public DateTime? PublishingPeriodDateStart { get; set; }

        /// <summary>
        /// publishing_period_date_end — date au-delà de laquelle l'article n'est plus publié.
        /// </summary>
        [JsonProperty("publishing_period_date_end")]
        public DateTime? PublishingPeriodDateEnd { get; set; }

        /// <summary>
        /// days_before_delivery — délai minimum (en jours) entre la commande et la livraison
        /// (= MinimumDaysForOrder côté Lets.TART, catalogues 12/43).
        /// </summary>
        [JsonProperty("days_before_delivery")]
        public int? DaysBeforeDelivery { get; set; }
    }
}
