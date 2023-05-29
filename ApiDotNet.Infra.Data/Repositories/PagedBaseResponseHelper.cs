using ApiDotNet.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Repositories
{
    public static class PagedBaseResponseHelper
    {
        public static async Task<TResponse> GetResponseAsync<TResponse, T>(IQueryable<T> query, PagedBaseRequest request)
            where TResponse : PagedBaseResponse<T>, new()
        {
            var response = new TResponse();
            response.TotalRegisters = await query.CountAsync();
            response.TotalPages = (int)Math.Ceiling((double)response.TotalRegisters / request.PageSize);
            if(string.IsNullOrEmpty(request.OrderBy))
            {
                response.Result = await query.ToListAsync();
            }
            else
            {
                response.Result =  query.OrderByDynamic(request.OrderBy)
                                        .Skip((request.Page - 1) * request.PageSize)
                                        .Take(request.PageSize)
                                        .ToList();      
            }
            return response;
        }
        private static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> query, string propertyName)
        {
            return query.OrderBy(x => x.GetType().GetProperty(propertyName).GetValue(x, null));
        }
    }

   
}
