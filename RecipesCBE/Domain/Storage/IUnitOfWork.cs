using Domain.Models.Users;
using Domain.Storage.Repositories;

namespace Domain.Storage
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }

        Task SaveChangesAsync();

        void SaveChanges();
    }
}
