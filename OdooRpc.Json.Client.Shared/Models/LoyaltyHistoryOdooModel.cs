using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("loyalty.history")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class LoyaltyHistoryOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("card_id")]
        public long? CardId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("issued")]
        public double? Issued { get; set; }

        /// <summary>
        /// Points consommés via un bon de réduction posé sur une ligne de vente.
        /// </summary>
        [JsonProperty("used")]
        public double? Used { get; set; }

        /// <summary>
        /// Nombre de points effectivement utilisés sur la ligne d'historique. Quand
        /// <c>used_given_points == issued</c>, la ligne est entièrement consommée et passe
        /// au statut <see cref="LoyaltyHistoryStatusOdooEnum.Used"/>. Le solde disponible se
        /// calcule donc sur <c>issued - used_given_points</c> des lignes encore Available.
        /// </summary>
        [JsonProperty("used_given_points")]
        public double? UsedGivenPoints { get; set; }

        /// <summary>
        /// Statut personnalisé Let's TART (selection Odoo) pour distinguer les points
        /// disponibles des points expirés.
        /// </summary>
        [JsonProperty("status")]
        public LoyaltyHistoryStatusOdooEnum? Status { get; set; }

        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date d'expiration de la ligne de points (champ <c>expiration_date</c> côté Odoo).
        /// Affichée dans la colonne "Expiration" de l'écran fidélité Odoo.
        /// </summary>
        [JsonProperty("expiration_date")]
        public DateTime? ExpirationDate { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoyaltyHistoryStatusOdooEnum
    {
        [EnumMember(Value = "available")]
        Available = 1,

        [EnumMember(Value = "expired")]
        Expired = 2,

        [EnumMember(Value = "used")]
        Used = 3,
    }
}
