using Domain.Models.Users;

namespace Domain.Services
{
    public interface IUserService
    {
        User GetUserById( int id );

        User GetUserByLogin( string userLogin );
    }
}
