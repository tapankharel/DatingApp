using System.Threading.Tasks;
using DatingApp.Api.Models;

namespace DatingApp.Api.Repository
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}