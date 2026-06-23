using Newtonsoft.Json;
using OdooRpc.Json.Client.Converters;
using System;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Extension de <see cref="ProductProductOdooModel"/> avec les champs custom Lets.TART
    /// présents sur le module Odoo : périodes d'achat/vente et nombre de jours avant livraison.
    /// Ces champs sont définis au niveau de la variante (<c>product.product</c>) dans le module
    /// Lets.TART ; on les pousse donc sur la variante et non sur le template.
    /// Le décorator <c>[OdooTableName]</c> hérite de la classe de base (= "product.product").
    /// </summary>
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductProductLetsTartOdooModel : ProductProductOdooModel
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

        /// <summary>
        /// public_categ_ids — many2many vers <c>product.public.category</c>. Lie l'article aux
        /// catégories visibles sur le site web. Lets.TART pousse une seule catégorie résolue
        /// depuis la classification de l'article (en fonction de WebGroupVisibility).
        /// </summary>
        [JsonProperty("public_categ_ids")]
        public long[] PublicCategIds { get; set; }
    }
}
