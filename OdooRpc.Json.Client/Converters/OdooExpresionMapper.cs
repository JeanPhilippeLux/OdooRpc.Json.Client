using OdooRpc.Json.Client.Extensions;
using OdooRpc.Json.Client.Models;
using System.Linq.Expressions;

namespace OdooRpc.Json.Client.Converters
{
    public static class OdooExpresionMapper
    {
        internal static string GetOdooPropertyName<T>(Expression<Func<T, object>> expression) where T : IOdooAtributtesModel
        {
            return OdooExtensions.GetOdooPropertyName<T>(GetPropertyName(expression));
        }

        internal static string GetPropertyName<T>(Expression<Func<T>> expression) where T : IOdooAtributtesModel
        {
            if (expression.Body is MemberExpression body)
                return body.Member.Name;

            if (expression.Body is UnaryExpression unar && unar.Operand is MemberExpression member)
                return member.Member.Name;

            return null;
        }
        internal static string GetPropertyName<T>(Expression<Func<T, object>> expression) where T : IOdooAtributtesModel
        {
            if (expression.Body is MemberExpression body)
                return body.Member.Name;

            if (expression.Body is UnaryExpression unar && unar.Operand is MemberExpression member)
                return member.Member.Name;

            return null;
        }
        internal static string GetPropertyName<T>(Expression<Func<T, Enum>> expression) where T : IOdooAtributtesModel
        {
            if (expression.Body is MemberExpression body)
                return body.Member.Name;

            if (expression.Body is UnaryExpression unar && unar.Operand is MemberExpression member)
                return member.Member.Name;

            return null;
        }

        internal static string GetPropertyName<T>(Expression<Func<T, long>> expression) where T : IOdooAtributtesModel
        {
            if (expression.Body is MemberExpression body)
                return body.Member.Name;

            if (expression.Body is UnaryExpression unar && unar.Operand is MemberExpression member)
                return member.Member.Name;

            return null;
        }

        internal static string GetPropertyName<T>(Expression<Func<T, long?>> expression) where T : IOdooAtributtesModel
        {
            if (expression.Body is MemberExpression body)
                return body.Member.Name;

            if (expression.Body is UnaryExpression unar && unar.Operand is MemberExpression member)
                return member.Member.Name;

            return null;
        }

    }
}