using Siri_Reality_API.Entities;
using Siri_Reality_API.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.Service
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public Task<User> EmailExists(string email)
        {
            return _userRepository.EmailExists(email);
        }

        public Task<List<User>> GetUsersList()
        {
            return _userRepository.GetUsersList();           
        }

        public User RegisterUser(User entity)
        {
            return _userRepository.RegisterUser(entity);
        }

        public bool UpdatePassword(User user)
        {
            return _userRepository.UpdatePassword(user);
        }

        public Task<User> ValidateUser(string Mobile, string password)
        {
            return _userRepository.ValidateUser(Mobile, password);
        }
    }
}
