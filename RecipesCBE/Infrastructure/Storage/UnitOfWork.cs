using Domain.Models.Users;
using Domain.Storage;
using Domain.Storage.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Storage
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private readonly IUserRepository _userRepository;

        public UnitOfWork( ApplicationContext context, IUserRepository userRepository )
        {
            _context = context;
            _userRepository = userRepository;
        }

        private async Task t()
        {
            string asda = "";
            var a = await FindUsers( ( User user ) => user.Login == asda );
        }

        IUserRepository IUnitOfWork.Users => _userRepository;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<List<User>> FindUsers( Expression<Func<User, bool>> predicate )
        {
            return _context.Users.Where( predicate ).ToListAsync();
        }
    }
}
