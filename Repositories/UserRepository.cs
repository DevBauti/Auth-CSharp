using Auth.Models;
namespace Auth.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", Email = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke", Surname = "Rogers", Role = "Administrator" },
            new() { Username = "lydia_standard", Email = "lydia.standard@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" },
        };
    }
}