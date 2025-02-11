using OdooRpc.Json.Client.Models;
using OdooRpc.Json.Client.Request;
using OdooRpc.Json.Client.Result;

namespace OdooRpc.Json.Client
{
    public interface IOdooRepository<T> where T : IOdooModel, new()
    {
        OdooQueryBuilder<T> Query();

        Task<OdooResult<long>> CreateAsync(IOdooCreateModel model, OdooContext context = null);
        Task<OdooResult<long>> CreateAsync(OdooDictionaryModel model, OdooContext context = null);

        Task<OdooResult<bool>> UpdateAsync(IOdooCreateModel model, long id, OdooContext context = null);
        Task<OdooResult<bool>> UpdateRangeAsync(IOdooCreateModel model, long[] ids, OdooContext context = null);
        Task<OdooResult<bool>> UpdateAsync(OdooDictionaryModel model, long id, OdooContext context = null);
        Task<OdooResult<bool>> UpdateRangeAsync(OdooDictionaryModel model, long[] ids, OdooContext context = null);

        Task<OdooResult<bool>> DeleteAsync(T model, OdooContext context = null);
        Task<OdooResult<bool>> DeleteAsync(long id, OdooContext context = null);
        Task<OdooResult<bool>> DeleteRangeAsync(T[] models, OdooContext context = null);
    }
}