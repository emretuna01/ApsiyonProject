using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApsiyonProject.Domain.App.Common;

namespace ApsiyonProject.Persistance.App.Common
{
    public class ApplicationDbRepository<T> : IApplicationDbRepository<T> where T : BaseEntity
    {
        public Task<int> AddRangeAsync(List<T> typeList)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddTypeAsync(T type)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> TruncateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
