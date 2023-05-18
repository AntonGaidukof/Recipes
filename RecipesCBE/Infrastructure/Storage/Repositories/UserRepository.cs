using Domain.Models.Users;
using Domain.Storage.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Storage.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository( ApplicationContext context )
        {
            _context = context;
        }


        public void AddUser( User user )
        {
            _context.Users.Add( user );
        }

        public async Task<User> GetUserAsync( Expression<Func<User, bool>> predicate )
        {
            return await _context.Users.FirstOrDefaultAsync( predicate );
        }

        public async Task<List<User>> GetUsersAsync( Expression<Func<User, bool>> predicate )
        {
            return await _context.Users.Where( predicate ).ToListAsync();
        }

        public void RemoveUser( User user )
        {
            _context.Users.Remove( user );
        }
    }
}
