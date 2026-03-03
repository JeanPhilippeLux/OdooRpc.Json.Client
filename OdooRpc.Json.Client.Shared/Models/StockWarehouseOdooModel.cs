using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared.Models
{
    [OdooTableName("stock.warehouse")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class StockWarehouseOdooModel : OdooModelBase
    {
        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        // required, max 5 chars
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        // res.company - required
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        // res.partner
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        // many2one resource.calendar (custom tartes.francoise - champ opening_hours)
        [JsonProperty("opening_hours")]
        public long? OpeningHours { get; set; }

        // selection: workshop, collect_point (custom tartes.francoise)
        [JsonProperty("warehouse_type")]
        public WarehouseTypeOdooEnum? WarehouseType { get; set; }

        // many2many vers tartes.francoise.closing.day (custom tartes.francoise)
        [JsonProperty("delivery_closed_day_ids")]
        public long[] DeliveryClosedDayIds { get; set; }

        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarehouseTypeOdooEnum
    {
        [EnumMember(Value = "workshop")]
        Workshop = 1,

        [EnumMember(Value = "collect_point")]
        CollectPoint = 2,
    }
}
