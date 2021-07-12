using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.Service
{
    public interface IUserService
    {
        User RegisterUser(User entity);
        Task<User> ValidateUser(string Mobile, string password);
        Task<User> EmailExists(string email);
        bool UpdatePassword(User entity);
        Task<List<User>> GetUsersList();
        void Delete(int id);
    }
}
