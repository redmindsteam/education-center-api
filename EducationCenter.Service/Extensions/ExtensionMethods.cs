using EducationCenter.Domain.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EducationCenter.Service.Extensions
{
    public static class ExtensionMethods
    {
        public async static Task<PagedList<T>> ToPagedListAsync <T> (
            this IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();

            var items = await source.Skip(
                (pageNumber - 1) * pageSize).Take(pageSize)
                .ToListAsync();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
