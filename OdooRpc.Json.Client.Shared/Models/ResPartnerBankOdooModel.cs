using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("res.partner.bank")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResPartnerBankOdooModel : IOdooModel
    {

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("acc_type")]
        public TypeResPartnerBankOdooEnum? AccType { get; set; }

        // required
        [JsonProperty("acc_number")]
        public string AccNumber { get; set; }

        [JsonProperty("sanitized_acc_number")]
        public string SanitizedAccNumber { get; set; }

        [JsonProperty("acc_holder_name")]
        public string AccHolderName { get; set; }

        // res.partner
        // required
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        // res.bank
        [JsonProperty("bank_id")]
        public long? BankId { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bank_bic")]
        public string BankBic { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        // res.currency
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        // res.company
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        // account.journal
        [JsonProperty("journal_id")]
        public long[] JournalId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        // "Compte de confiance / approuvé" (Send Money). Quand true, le core Odoo interdit de
        // modifier acc_number ou partner_id (account/models/res_partner_bank.py). Nécessite le
        // groupe account.group_validate_bank_account pour être modifié.
        [JsonProperty("allow_out_payment")]
        public bool? AllowOutPayment { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        // res.users
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        // res.users
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }
    }


    // Bank account type: Normal or IBAN. Inferred from the bank account number.
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeResPartnerBankOdooEnum
    {
        [EnumMember(Value = "bank")]
        Normal = 1,

        [EnumMember(Value = "iban")]
        IBAN = 2,
    }

}