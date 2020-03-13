using Dominio.Interfaces;
using Infraestrutura.Interfaces.Respositories.Domain.EFCore;
using Infraestrutura.Interfaces.Respositories.Standard;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Standard.EFCore
{
    public class RepositoryAsync<TEntity> : SpecificMethods<TEntity>, IRepositoryAsync<TEntity> where TEntity : class, IEntidadeIdentidade
    {
        protected readonly DbContext dbContext;
        protected readonly DbSet<TEntity> dbSet;

        protected RepositoryAsync(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<TEntity>();
        }

        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            var response = await dbSet.AddAsync(obj);
            await dbContext.SaveChangesAsync();
            return response.Entity;
        }

        public async Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await dbSet.AddRangeAsync(entities);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await Task.FromResult(dbSet);

        public async Task<int> UpdateAsync(TEntity obj)
        {
            dbContext.Entry(obj).State = EntityState.Modified;
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            dbSet.UpdateRange();
            return await dbContext.SaveChangesAsync();
        }

        public async Task<bool> RemoveAsync(object id)
        {
            TEntity entity = await GetByIdAsync(id);
            if (entity == null) return false;
            dbSet.Remove(entity);
            return await dbContext.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<int> RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
            return await dbContext.SaveChangesAsync(); 
        }

    }
}
