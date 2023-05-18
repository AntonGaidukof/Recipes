using Domain.Models.Users;
using System.Linq.Expressions;

namespace Domain.Storage.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync( Expression<Func<User, bool>> predicate );

        Task<List<User>> GetUsersAsync( Expression<Func<User, bool>> predicate );

        void AddUser( User user );

        void RemoveUser( User user );
    }
}
