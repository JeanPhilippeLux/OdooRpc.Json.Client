using System.Reflection;
using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Consts;
using OdooRpc.Json.Client.Models;
using OdooRpc.Json.Client.Result;

namespace OdooRpc.Json.Client.Extensions
{
    public static class OdooExtensions
    {
        public static string GetOdooTableName<T>() where T : IOdooAtributtesModel
        {
            if (!(typeof(T).GetCustomAttributes(typeof(OdooTableNameAttribute), true).FirstOrDefault() is OdooTableNameAttribute attribute))
                throw new ArgumentException($"Mising attribute '{nameof(OdooTableNameAttribute)}' for model '{typeof(T).Name}'");
            return attribute.Name;
        }

        public static string GetOdooPropertyName<T>(string name) where T : IOdooAtributtesModel
        {
            var property = typeof(T).GetProperties().First(x => string.Equals(x.Name, name));
            var attribute = property.GetCustomAttributes<JsonPropertyAttribute>();

            return attribute.FirstOrDefault()?.PropertyName;
        }

        public static OdooResult<TResult> ToResult<T, TResult>(this OdooResult<T> result, TResult newValue)
        {
            return new OdooResult<TResult> { Id = result.Id, Jsonrpc = result.Jsonrpc, Value = newValue };
        }

        public static string ToOdooDateTimeString(this DateTime date)
        {
            return date.ToString(OdooConsts.DateTimeFormat);
        }
        public static string ToOdooDateString(this DateTime date)
        {
            return date.ToString(OdooConsts.DateFormat);
        }
    }
}