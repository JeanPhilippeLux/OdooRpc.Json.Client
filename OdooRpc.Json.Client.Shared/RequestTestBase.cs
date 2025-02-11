using OdooRpc.Json.Client.Models;

namespace OdooRpc.Json.Client.Shared
{
    public class RequestTestBase
    {
        protected static readonly OdooConfig TestConfig = new OdooConfig(
            apiUrl: "http://localhost:8069", // "https://db-name.dev.odoo.com"
            dbName: "db-test",
            userName: "admin",
            password: "admin"
        );
    }
}