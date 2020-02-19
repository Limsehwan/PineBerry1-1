using Microsoft.EntityFrameworkCore;
using PineBerry01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PineBerry01.Controllers
{
    public class PaginatedList<T> : List<T>
    {
        public int pageIndex { get; private set; }
        public int TotalPages { get; private set; }
         
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            pageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        public bool HasPreviousPage
        {
            get
            {
                return (pageIndex > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (pageIndex < TotalPages);
            }
        }
        public static async Task<PaginatedList<T>> GetTsAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        internal static Task<object> CreateAsync(IQueryable<QnA> queryable, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
