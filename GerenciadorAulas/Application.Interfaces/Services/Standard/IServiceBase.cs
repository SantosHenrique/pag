using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.Standard
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<int> UpdateAsync(TEntity obj);
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task<bool> RemoveAsync(object id);
        Task<int> RemoveAsyncRange(IEnumerable<TEntity> entities);
    }
}
