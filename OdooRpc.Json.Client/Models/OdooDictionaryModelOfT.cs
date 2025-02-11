using OdooRpc.Json.Client.Extensions;
using System.Linq.Expressions;

namespace OdooRpc.Json.Client.Models
{
    public class OdooDictionaryModel<T> : OdooDictionaryModel where T : IOdooAtributtesModel, new()
    {
        public OdooDictionaryModel()
        {
            TableName = OdooExtensions.GetOdooTableName<T>();
        }
 
        public static OdooDictionaryModel<T> Create(Expression<Func<T>> expression)
        {
            return new OdooDictionaryModel<T>().Add(expression);
        }

        public static OdooDictionaryModel<T> Create(Expression<Func<T, object>> expression, object value)
        {
            return new OdooDictionaryModel<T>().AddOrUpdate(expression, value);
        }

        public OdooDictionaryModel<T> AddOrUpdate(Expression<Func<T, object>> expression, object value)
        {
            AddOrUpdate<T>(expression, value);
            return this;
        }

        public OdooDictionaryModel<T> Add(Expression<Func<T>> expression)
        {
            AddFromExpresion(expression);
            return this;
        }
    }
}