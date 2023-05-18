using Domain.Models.Users;
using Domain.Storage;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService( IUnitOfWork unitOfWork  )
        {
            _unitOfWork = unitOfWork;
        }

        public User GetUserById( int id )
        {
            return _unitOfWork.Users.FirstOrDefault( u => u.Id == id );
        }

        public User GetUserByLogin( string userLogin )
        {
            return _unitOfWork.Users.FirstOrDefault( u => u.Login == userLogin );
        }

        public Task<User> GetUserByLoginAsync( string userLogin )
        {
            return _unitOfWork.Users.FirstOrDefaultAsync( u => u.Login == userLogin );
        }
    }
}
