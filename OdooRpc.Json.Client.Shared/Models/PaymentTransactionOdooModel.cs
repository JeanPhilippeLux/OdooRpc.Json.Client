using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Modèle Odoo <c>payment.transaction</c> — transaction de paiement (e-commerce, virement, etc.)
    /// liée à une <c>sale.order</c> via <c>sale.order.transaction_ids</c>. Lets.TART consomme
    /// principalement <c>amount</c> et <c>state</c> à l'import e-commerce pour matérialiser
    /// le prépaiement sur la SalesTable correspondante.
    /// </summary>
    [OdooTableName("payment.transaction")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PaymentTransactionOdooModel : OdooModelBase
    {
        /// <summary>Référence interne (numéro de transaction).</summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>Montant de la transaction.</summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>État : draft, pending, authorized, done, cancel, error.</summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>res.partner — client payeur.</summary>
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        /// <summary>res.currency.</summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>Date de la dernière modification (souvent la date de validation côté PSP).</summary>
        [JsonProperty("last_state_change")]
        public System.DateTime? LastStateChange { get; set; }
    }
}
