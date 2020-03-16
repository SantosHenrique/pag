using Application.Interfaces.Services.Standard;
using Dominio.Interfaces;
using Infraestrutura.Interfaces.Respositories.Standard;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Standard
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class, IEntidadeIdentidade
    {
        protected readonly IRepositoryAsync<TEntity> _repository;

        public ServiceBase(IRepositoryAsync<TEntity> repository)
        {
            _repository = repository;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            return _repository.AddAsync(entity);
        }

        public Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return _repository.AddRangeAsync(entities);
        }

        public Task<TEntity> GetByIdAsync(object id)
        {
            return _repository.GetByIdAsync(id);
        } 

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<int> UpdateAsync(TEntity entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            return _repository.UpdateRangeAsync(entities);
        }

        public Task<bool> RemoveAsync(object id)
        {
            return _repository.RemoveAsync(id);
        }
        
        public Task<int> RemoveAsyncRange(IEnumerable<TEntity> entities)
        {
            return _repository.RemoveAsyncRange(entities);
        }
    }
}
