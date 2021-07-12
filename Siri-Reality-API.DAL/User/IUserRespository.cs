using Siri_Reality_API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Siri_Reality_API.DAL
{
    public interface IUserRepository
    {
        User RegisterUser(User user); 
        Task<User> ValidateUser(string Mobile, string password);
        Task<User> EmailExists(string email);
        bool UpdatePassword(User user);
        Task<List<User>> GetUsersList();
        void Delete(int id);
    }
}
