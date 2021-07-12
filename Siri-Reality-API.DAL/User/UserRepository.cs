using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using Dapper;
using MySql.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Siri_Reality_API.DAL
{
    public class UserRepository : IUserRepository
    {
        protected readonly IConfiguration _config;
        public UserRepository(IConfiguration config)
        {
            _config = config;
        }

        public MySqlConnection Connection
        {
            get
            {
                return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection connection = this.Connection)
                {
                    connection.Open();
                    string query = "Delete From Users Where Id= @Id";
                    connection.Execute(query, new { Id = id });                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> EmailExists(string email)
        {
            try
            {
                using (var connection = this.Connection)
                {
                    string query = "SELECT Id as UserId, Type, FullName, Mobile, UserName, Password, Gender, Email, Status FROM Users Where Email = @Email";
                    var users = await connection.QueryAsync<User>(query, new { Email = email });
                    return users.FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<User>> GetUsersList()
        {
            IEnumerable<User> users = new List<User>();
            using (var connection = this.Connection)
            {
                users = await connection.QueryAsync<User>("SELECT Id as UserId, Type, FullName, Mobile, UserName, Password, Gender, Email, Status FROM Users");
            }
            return users.ToList();
        }

        public User RegisterUser(User entity)
        {
            try
            {
                using (MySqlConnection connection = this.Connection)
                {
                    connection.Open();
                    string query = @"INSERT INTO Users(Type, FullName, Mobile, UserName, Password, Gender, Email, Status) " +
                        "VALUES(@Type, @FullName, @Mobile, @UserName, @Password, @Gender, @Email,@Status);";
                    connection.Execute(query, entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public bool UpdatePassword(User entity)
        {
            try
            {
                using (MySqlConnection connection = this.Connection)
                {
                    connection.Open();
                    string query = "Update User Set Password = @Password Where UserName = @UserId);";
                    int rows = connection.Execute(query, new { Password = entity.Password, UserName = entity.UserName });
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> ValidateUser(string Mobile, string password)
        {
            using (var connection = this.Connection)
            {
                string query = "SELECT Id as UserId, Type, FullName, Mobile, UserName, Password, Gender, Email, Status FROM Users Where Mobile = @Mobile and Password = @Password";
                var users = await connection.QueryAsync<User>(query,new { Mobile = Mobile, Password = password });
                return users.FirstOrDefault();
            }           
        }
    }
}
