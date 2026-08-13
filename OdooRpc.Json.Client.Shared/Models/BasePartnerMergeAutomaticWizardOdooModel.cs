using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared.Models
{
    /// <summary>
    /// Wizard transient Odoo de fusion de contacts (modèle <c>base.partner.merge.automatic.wizard</c>),
    /// celui utilisé par l'action "Fusionner" de la vue liste des contacts.
    ///
    /// Fonctionnement : on le crée avec <see cref="PartnerIds"/> = les partners à fusionner et
    /// <see cref="DstPartnerId"/> = le partner à CONSERVER, puis on appelle <c>action_merge</c>.
    /// Odoo repointe alors toutes les références (pos.order, sale.order, account.move, adresses
    /// enfants, abonnements…) des doublons vers le partner conservé, puis retire les doublons.
    ///
    /// C'est la seule façon fiable de "supprimer" un doublon client : un <c>unlink</c> direct sur
    /// res.partner est refusé par Odoo dès qu'une commande ou une facture y est rattachée.
    /// </summary>
    [OdooTableName("base.partner.merge.automatic.wizard")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class BasePartnerMergeAutomaticWizardOdooModel : IOdooModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// res.partner (many2many) : l'ENSEMBLE des partners concernés par la fusion, doublons
        /// ET partner conservé inclus.
        /// </summary>
        [JsonProperty("partner_ids")]
        public long[] PartnerIds { get; set; }

        /// <summary>
        /// res.partner (many2one) : le partner CONSERVÉ. Les autres <see cref="PartnerIds"/> sont
        /// fusionnés dedans puis retirés.
        /// </summary>
        [JsonProperty("dst_partner_id")]
        public long? DstPartnerId { get; set; }

        /// <summary>État du wizard ('option', 'selection', 'finished'). Renseigné par Odoo.</summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>Nombre de groupes de doublons restant à traiter (mode recherche automatique).</summary>
        [JsonProperty("number_group")]
        public int? NumberGroup { get; set; }
    }
}
