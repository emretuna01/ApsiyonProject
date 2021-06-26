using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApsiyonProject.Domain.App.Common;

namespace ApsiyonProject.Application.App.Common.Interfaces.DbRepository
{
    public interface IApplicationDbRepository<T> where T : BaseEntity
    {
        public Task<T> GetTypeAsync();
        public Task<List<T>> GetListAsync();
        public Task<T> GetWhereAsync(Expression<Func<T,bool>> expression);        
        public Task AddTypeAsync(T type);
        public Task AddRangeAsync(List<T> typeList);
        public Task TruncateAsync();


    }
}
