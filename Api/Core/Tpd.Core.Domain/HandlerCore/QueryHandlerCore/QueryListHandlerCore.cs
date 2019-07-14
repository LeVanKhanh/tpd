using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Domain.FluentValidationCore;
using Tpd.Core.Domain.Helper;
using Tpd.Core.Domain.RequestCore.QueryCore;
using Tpd.Core.Domain.ResultCore;

namespace Tpd.Core.Domain.HandlerCore.QueryHandlerCore
{
    public abstract class QueryListHandlerCore<TQuery, TResponse> : QueryHandlerCore<TQuery, PagedResultCore<TResponse>>
        where TQuery : IQueryListCore<TResponse>
        where TResponse : new()
    {
        public QueryListHandlerCore(DatabaseContextCore data, IValidationService validationService)
            : base(data, validationService)
        {
        }
        //
        // Summary:
        //     This function for Handling a request to get list of items.
        //     Checks is build command(s) success or not then execute the command(s)
        // Return:
        //     Petronas.Core.Domain.ResultBases.IResultBase<PagedResult<TResultType>>.
        //     With this result can be known the request is handled success or not.
        //     And the result also contain message(s) if gets error(s).
        //     TResultType: type of item will be get list.
        //     Petronas.Core.Domain.ResultBases.PagedResult<T> will provide information about the list as list items, 
        //     total items.
        protected sealed async override Task<IResultCore<PagedResultCore<TResponse>>> Handle(TQuery query, RequestContextCore context)
        {
            var result = new ResultCore<PagedResultCore<TResponse>>
            {
                Success = true,
                Result = new PagedResultCore<TResponse>()
            };

            var queryable = await BuildQueryAsync(query, context);

            if (queryable == null)
            {
                result.Success = false;
                result.ErrorMessages = query.Messages;
                return result;
            }

            result.Result.TotalRow = queryable.Count();

            if (!string.IsNullOrEmpty(query.OrderBy))
            {
                queryable = queryable.OrderBy(query.OrderBy, query.OrderByDirection);
            }

            if (query.IsPaged)
            {
                result.Result.Skip = query.Skip;
                result.Result.Take = query.Take;
                queryable = queryable.Skip(query.Skip).Take(query.Take);
            }

            result.Success = true;
            result.Result.Result = await queryable.ToListAsync();

            return result;
        }
        //
        // Summary:
        //     Requires derived class to implement this function.
        //     Derived class will implement this function to build query.
        // Return:
        //     System.Boolean is build query success or not.
        protected abstract Task<IQueryable<TResponse>> BuildQueryAsync(TQuery query, RequestContextCore context);
    }
}
