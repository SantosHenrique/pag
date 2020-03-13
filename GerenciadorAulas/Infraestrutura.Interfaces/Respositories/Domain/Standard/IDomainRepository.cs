using Dominio.Interfaces;
using Infraestrutura.Interfaces.Respositories.Standard;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Interfaces.Respositories.Domain.Standard
{
    public interface IDomainRepository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class, IEntidadeIdentidade
    {
    }
}
