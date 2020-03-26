using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Repositories
{
    public interface IRepository<TEntity,T> where TEntity : class 
    {
        void Add(TEntity entity);
        void AddAll(IEnumerable<TEntity> entities);

        TEntity Get(T id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entity);

        int Count();
    }
}
