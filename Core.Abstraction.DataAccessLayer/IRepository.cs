namespace Core.Abstraction.DataAccessLayer
{
    using Core.DomainModel.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : IEntity
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Find(int id);

        Task InsertAsync(T entity);

        Task<T> FindAsync(int id);

        IQueryable<T> Get();

        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
