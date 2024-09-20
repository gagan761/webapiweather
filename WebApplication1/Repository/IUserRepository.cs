using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IUserRepository
    {
        UserDetail GetUser(string username, string password);
    }
}
