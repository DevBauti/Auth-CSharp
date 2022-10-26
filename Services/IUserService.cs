using Auth.Models;

namespace Auth.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}