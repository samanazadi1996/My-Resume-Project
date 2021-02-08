namespace Infrastructure.Implementation.DataAccessLayer
{
    using Core.Abstraction.DataAccessLayer;
    using Infrastructure.DomainModel.Common;
    using Infrastructure.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class UnitOfWork<T> : IDisposable, IUnitOfWork<T> where T : IEntity
    {
        private readonly ApplicationDbContext databaseContext;
        public IRepository<T> Repository { get; set; }

        public UnitOfWork(ApplicationDbContext databaseContext, IRepository<T> repository)
        {
            this.databaseContext = databaseContext;
            this.Repository = repository;
            databaseContext.Database.Migrate();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public virtual void Save()
        {
            databaseContext.SaveChanges();
        }

        public virtual async Task SaveAsync()
        {
            await databaseContext.SaveChangesAsync();
        }

    }
}
