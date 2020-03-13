using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infraestrutura.Interfaces.Respositories.Domain.EFCore
{
    public abstract class SpecificMethods<TEntity> where TEntity : class, IEntidadeIdentidade
    {
        #region ProtectedMethods
        protected abstract IQueryable<TEntity> GenerateQuery(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includeProperties);

        protected abstract IEnumerable<TEntity> GetYeldManipulated(IEnumerable<TEntity> entities, Func<TEntity, TEntity> DoAction);
        #endregion ProtectedMethods
    }
}
