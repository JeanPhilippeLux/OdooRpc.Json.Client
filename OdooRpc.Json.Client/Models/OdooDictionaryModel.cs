﻿using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;
using OdooRpc.Json.Client.Attributes;
using OdooRpc.Json.Client.Converters;

namespace OdooRpc.Json.Client.Models
{
    public class OdooDictionaryModel : Dictionary<string, object>
    {

        public OdooRecordsListStructure GetRecord()
        {
            OdooRecordsListStructure odooRecordsListStructure = new OdooRecordsListStructure();

            foreach (var key in this.Keys)
            {

                odooRecordsListStructure.Add(key, this[key]);
            }
            return odooRecordsListStructure;
        }

        public string TableName { get; internal set; }

        public OdooDictionaryModel() { }

        public OdooDictionaryModel(string tableName)
        {
            TableName = tableName;
        }

        public static OdooDictionaryModel Create()
        {
            return new OdooDictionaryModel();
        }

        public static OdooDictionaryModel Create(string tableName)
        {
            return new OdooDictionaryModel(tableName);
        }

        public static OdooDictionaryModel<T> Create<T>() where T : IOdooAtributtesModel, new()
        {
            return new OdooDictionaryModel<T>();
        }

        public static OdooDictionaryModel<T> Create<T>(Expression<Func<T>> expression) where T : IOdooAtributtesModel, new()
        {
            return new OdooDictionaryModel<T>().Add(expression);
        }

        public static OdooDictionaryModel Create<T>(Expression<Func<T, object>> expression, object value) where T : IOdooAtributtesModel, new()
        {
            return new OdooDictionaryModel<T>().AddOrUpdate(expression, value);
        }

        //TODO: Rename to set / addOrUpdate ?

        public OdooDictionaryModel AddOrUpdate<T>(Expression<Func<T, object>> expression, object value) where T : IOdooAtributtesModel
        {
            if (TableName != null && TryGetOdooTableName(expression, out var tableName))
                TableName = tableName;
            this[OdooExpresionMapper.GetOdooPropertyName(expression)] = value;
            return this;
        }

        public OdooDictionaryModel Add<T>(Expression<Func<T>> expression) where T : IOdooAtributtesModel, new()
        {
            if (TableName == null && TryGetOdooTableName(expression, out var tableName))
                TableName = tableName;

            AddFromExpresion(expression);

            return this;
        }

        protected void AddFromExpresion<T>(Expression<Func<T>> expression) where T : IOdooAtributtesModel, new()
        {
            if (expression.Body is MemberInitExpression body)
            {

                foreach (var memberExpression in body.Bindings)
                {
                    if (memberExpression is MemberAssignment memberExp)
                    {
                        var property = (PropertyInfo)memberExpression.Member;
                        var attribute = property.GetCustomAttributes<JsonPropertyAttribute>();

                        var odooName = attribute.FirstOrDefault()?.PropertyName;

                        if (odooName != null)
                        {
                            switch (memberExp.Expression)
                            {
                                case ConstantExpression constantExpression:
                                    {
                                        var value = constantExpression.Value;
                                        this[odooName] = value;
                                        continue;
                                    }
                                case MemberExpression memberExpr:
                                    {
                                        var value = Expression.Lambda(memberExpr).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case UnaryExpression unaryExpression:
                                    {
                                        var value = Expression.Lambda(unaryExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case MethodCallExpression methodCallExpression:
                                    {
                                        var value = Expression.Lambda(methodCallExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case NewExpression memberInitExpression:
                                    {
                                        var value = Expression.Lambda(memberInitExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case NewArrayExpression newArrayExpression:
                                    {
                                        var value = Expression.Lambda(newArrayExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case ConditionalExpression conditionalExpression:
                                    {
                                        var value = Expression.Lambda(conditionalExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                case BinaryExpression binaryExpression:
                                    {
                                        var value = Expression.Lambda(binaryExpression).Compile().DynamicInvoke();
                                        this[odooName] = value;
                                        continue;
                                    }
                                default:
                                    throw new ArgumentException($"Unsupported expression type: {memberExp.Expression.GetType()}");
                            }
                        }
                    }
                }

            }
            else if (expression.Body is MemberExpression memberExpr)
            {
                // Exemple: () => obj.resPartnerBankOdooModel
                var value = Expression.Lambda(memberExpr).Compile().DynamicInvoke();

                if (value is IOdooAtributtesModel odooModel)
                {
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        var attribute = prop.GetCustomAttributes<JsonPropertyAttribute>();
                        var odooName = attribute.FirstOrDefault()?.PropertyName;

                        if (odooName != null)
                        {
                            var val = prop.GetValue(odooModel);
                            this[odooName] = val;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("Invalid Func");
            }
        }


        protected static bool TryGetOdooTableName<T>(Expression<Func<T>> expression, out string result)
        {
            result = null;
            var tableNameAttribute = expression.ReturnType.GetCustomAttributes(typeof(OdooTableNameAttribute), true).FirstOrDefault() as OdooTableNameAttribute;
            if (tableNameAttribute == null) return false;

            result = tableNameAttribute.Name;
            return true;
        }

        protected static bool TryGetOdooTableName<T>(Expression<Func<T, object>> expression, out string result)
        {
            result = null;
            var tableNameAttribute = expression.ReturnType.GetCustomAttributes(typeof(OdooTableNameAttribute), true).FirstOrDefault() as OdooTableNameAttribute;
            if (tableNameAttribute == null) return false;

            result = tableNameAttribute.Name;
            return true;
        }

        protected static bool TryGetOdooTableName<T>(Expression<Func<T, Enum>> expression, out string result)
        {
            result = null;
            var tableNameAttribute = expression.ReturnType.GetCustomAttributes(typeof(OdooTableNameAttribute), true).FirstOrDefault() as OdooTableNameAttribute;
            if (tableNameAttribute == null) return false;

            result = tableNameAttribute.Name;
            return true;
        }
    }
}