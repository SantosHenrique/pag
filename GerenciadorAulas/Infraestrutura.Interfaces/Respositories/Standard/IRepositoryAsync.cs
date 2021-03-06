﻿using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Interfaces.Respositories.Standard
{
    public interface IRepositoryAsync<TEntity> : IDisposable where TEntity : class, IEntidadeIdentidade
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<int> UpdateAsync(TEntity obj);
        Task<int> UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task<bool> RemoveAsync(object id);
        Task<int> RemoveAsyncRange(IEnumerable<TEntity> entities);
    }
}
