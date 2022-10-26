using Auth.Models;
using Auth.Repositories;

namespace Auth.Services
{
    public class Userservice : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o => o.Username.Equals(userLogin.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(userLogin.Password))!;
            return user;
        }
    }
}