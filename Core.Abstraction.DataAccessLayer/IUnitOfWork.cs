using Infrastructure.DomainModel.Common;
using Infrastructure.DomainModel.Identity;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccessLayer
{

    public interface IUnitOfWork<T> where T : IEntity
    {
        IRepository<T> Repository { get; set; }
        void Dispose();
        void Save();
        Task SaveAsync();
    }
}
