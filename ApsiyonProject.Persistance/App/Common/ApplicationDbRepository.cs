using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApsiyonProject.Domain.App.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ApsiyonProject.Persistance.App.Common
{
    public class ApplicationDbRepository<T> : IApplicationDbRepository<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext _aplicationDbContext;
        public DbSet<T> _entity;

        public ApplicationDbRepository(ApplicationDbContext aplicationDbContext)
        {
            _aplicationDbContext = aplicationDbContext;
            _entity = aplicationDbContext.Set<T>();
        }

        public async Task AddRangeAsync(List<T> typeList)
        {
            await _entity.AddRangeAsync(typeList);
          
        }
               
        public async Task AddTypeAsync(T type)
        {
            await _entity.AddAsync(type);
        }

        public async Task<EntityEntry<T>> AddTypeWithReturnAsync(T type)
        {
          return  await _entity.AddAsync(type);
            
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _entity.ToListAsync();
        }

        public async Task<T> GetTypeAsync()
        {
            return await _entity.FirstOrDefaultAsync();
        }

        public async Task<T> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await _entity.Where(expression).FirstOrDefaultAsync();
        }
        public async Task<T> GetWhereAsync(Guid id)
        {
            return await _entity.Where(p =>p.Id==id).FirstOrDefaultAsync();
        }

        public void Update(T type)
        {             
            _entity.Update(type);           
        }


        public async Task TruncateAsync()
        {
           _entity.RemoveRange(await _entity.ToListAsync());            
        }
    }
}
