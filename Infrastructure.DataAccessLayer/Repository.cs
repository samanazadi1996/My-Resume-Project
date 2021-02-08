namespace Infrastructure.Implementation.DataAccessLayer
{
    using Core.Abstraction.DataAccessLayer;
    using Infrastructure.DomainModel.Common;
    using Infrastructure.Persistence;
    using Infrastructure.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext databaseContext;

        public Repository(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
            DbSet = this.databaseContext.Set<T>();
        }

        protected DbSet<T> DbSet { get; set; }

        public virtual void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            DbSet.Add(entity);
        }

        public virtual async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await DbSet.AddAsync(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            databaseContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.IsDeleted = true;
            entity.DeleteDateTime = DateTime.Now;
            Update(entity);
        }

        public virtual T Find(int id)
        {
            return DbSet.Find(id);
        }

        public virtual async Task<T> FindAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual IQueryable<T> Get()
        {
            return DbSet;
        }
    }
}
