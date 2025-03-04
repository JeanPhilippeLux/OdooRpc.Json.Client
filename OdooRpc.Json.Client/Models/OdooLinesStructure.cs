using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooRpc.Json.Client.Models
{
    public class OdooLinesStructure : List<object>
    {

        /// <summary>
        /// Add element to list of lines used in Odoo structure to add lines with a header in RPC call.
        /// </summary>
        /// <param name="odooLinesCommands">Command of the record.</param>
        /// <param name="odooRecordId">Id of record used for the commands Update, Delete, Unlink and Link. Must be O for commands Create, Clear and Set.</param>
        /// <param name="odooDictionaryModel">Record to add in list.</param>
        public void AddElement(OdooLinesCommands odooLinesCommands, long odooRecordId, OdooDictionaryModel odooDictionaryModel)
        {
            this.Add(new object[] { (int)odooLinesCommands, odooRecordId, odooDictionaryModel.GetRecord() }.ToArray());
        }

        /// <summary>
        /// Add element to list of lines used in Odoo structure to add lines with a header in RPC call.
        /// </summary>
        /// <param name="odooLinesCommands">Command of the record.</param>
        /// <param name="odooRecordId">Id of record used for the commands Update, Delete, Unlink and Link. Must be O for commands Create, Clear and Set.</param>
        /// <param name="value">List of integer to add directly in the list.</param>
        public void AddElement(OdooLinesCommands odooLinesCommands, long odooRecordId, List<long> value)
        {
            this.Add(new object[] { (int)odooLinesCommands, odooRecordId, value }.ToArray());
        }

        /// <summary>
        /// Add element to list of lines with only ID?
        /// </summary>
        /// <param name="odooLinesCommands">Command of the record.</param>
        /// <param name="odooRecordId">Element Id</param>
        public void AddElement(OdooLinesCommands odooLinesCommands, long odooRecordId)
        {
            this.Add(new object[] { (int)odooLinesCommands, odooRecordId }.ToArray());
        }

    }


    public enum OdooLinesCommands
    {
        Create = 0,
        Update = 1,
        Delete = 2,
        Unlink = 3,
        Link = 4,
        Clear = 5,
        Set = 6
    }
}
