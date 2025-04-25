using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Runtime.Serialization;

namespace OdooRpc.Json.Client.Shared
{
    [OdooTableName("account.analytic.plan")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class AccountAnalyticPlanOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("children_ids")]
        public long[] ChildrenIds { get; set; }

        // required
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public Dictionary<int, string> ParentId { get; set; }

        [JsonIgnore]
        public bool IsRoot
        {
            get
            {
                return ParentId == null;
            }
        }
    }


   

}



#region automatic

//[OdooTableName("account.analytic.plan")]
//[JsonConverter(typeof(OdooModelConverter))]
//public class AccountAnalyticPlanOdooModel : IOdooModel
//{

//    /// <summary>
//    /// name - char  <br />
//    /// Required: True, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("name")]
//    public string Name { get; set; }

//    /// <summary>
//    /// description - text  <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("description")]
//    public string Description { get; set; }

//    /// <summary>
//    /// parent_id - many2one - account.analytic.plan <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("parent_id")]
//    public long? ParentId { get; set; }

//    /// <summary>
//    /// parent_path - char  <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("parent_path")]
//    public string ParentPath { get; set; }

//    /// <summary>
//    /// root_id - many2one - account.analytic.plan <br />
//    /// Required: False, Readonly: True, Store: False, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("root_id")]
//    public long? RootId { get; set; }

//    /// <summary>
//    /// children_ids - one2many - account.analytic.plan (parent_id) <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("children_ids")]
//    public long[] ChildrenIds { get; set; }

//    /// <summary>
//    /// children_count - integer  <br />
//    /// Required: False, Readonly: True, Store: False, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("children_count")]
//    public int? ChildrenCount { get; set; }

//    /// <summary>
//    /// complete_name - char  <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("complete_name")]
//    public string CompleteName { get; set; }

//    /// <summary>
//    /// account_ids - one2many - account.analytic.account (plan_id) <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("account_ids")]
//    public long[] AccountIds { get; set; }

//    /// <summary>
//    /// account_count - integer  <br />
//    /// Required: False, Readonly: True, Store: False, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("account_count")]
//    public int? AccountCount { get; set; }

//    /// <summary>
//    /// all_account_count - integer  <br />
//    /// Required: False, Readonly: True, Store: False, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("all_account_count")]
//    public int? AllAccountCount { get; set; }

//    /// <summary>
//    /// color - integer  <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("color")]
//    public int? Color { get; set; }

//    /// <summary>
//    /// sequence - integer  <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("sequence")]
//    public int? Sequence { get; set; }

//    /// <summary>
//    /// default_applicability - selection  <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("default_applicability")]
//    public DefaultApplicabilityAccountAnalyticPlanOdooEnum? DefaultApplicability { get; set; }

//    /// <summary>
//    /// applicability_ids - one2many - account.analytic.applicability (analytic_plan_id) <br />
//    /// Required: False, Readonly: False, Store: True, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("applicability_ids")]
//    public long[] ApplicabilityIds { get; set; }

//    /// <summary>
//    /// id - integer  <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("id")]
//    public long Id { get; set; }

//    /// <summary>
//    /// display_name - char  <br />
//    /// Required: False, Readonly: True, Store: False, Sortable: False <br />
//    /// </summary>
//    [JsonProperty("display_name")]
//    public string DisplayName { get; set; }

//    /// <summary>
//    /// create_uid - many2one - res.users <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("create_uid")]
//    public long? CreateUid { get; set; }

//    /// <summary>
//    /// create_date - datetime  <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("create_date")]
//    public DateTime? CreateDate { get; set; }

//    /// <summary>
//    /// write_uid - many2one - res.users <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("write_uid")]
//    public long? WriteUid { get; set; }

//    /// <summary>
//    /// write_date - datetime  <br />
//    /// Required: False, Readonly: True, Store: True, Sortable: True <br />
//    /// </summary>
//    [JsonProperty("write_date")]
//    public DateTime? WriteDate { get; set; }
//}


///// <summary>
///// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
//public enum DefaultApplicabilityAccountAnalyticPlanOdooEnum
//{
//    [EnumMember(Value = "optional")]
//    Optional = 1,

//    [EnumMember(Value = "mandatory")]
//    Mandatory = 2,

//    [EnumMember(Value = "unavailable")]
//    Unavailable = 3,
//}

#endregion
