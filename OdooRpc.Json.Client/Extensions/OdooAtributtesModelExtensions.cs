using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;
using OdooRpc.Json.Client.Models;
using System.Linq.Expressions;

namespace OdooRpc.Json.Client.Extensions
{
    public static class OdooAtributtesModelExtensions
    {
        public static string OdooTableName(this IOdooAtributtesModel model)
        {
            if (!(model.GetType().GetCustomAttributes(typeof(OdooTableNameAttribute), true).FirstOrDefault() is OdooTableNameAttribute attribute))
                throw new ArgumentException($"Mising attribute '{nameof(OdooTableNameAttribute)}' for model '{model.GetType().Name}'");
            return attribute.Name;
        }

        public static string OdooPropertyName<T>(this T model, string name) where T : IOdooAtributtesModel
        {
            return OdooExtensions.GetOdooPropertyName<T>(name);
        }

        public static string OdooPropertyName<T>(this T model, Expression<Func<T, object>> expression) where T : IOdooAtributtesModel
        {
            return OdooExpresionMapper.GetOdooPropertyName(expression);
        }
    }
}