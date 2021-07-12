using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;
using System.Linq;

namespace Siri_Reality_API.DAL
{
    class PropertyTypeRepository : IPropertyTypeRepository
    {
        protected readonly IConfiguration _config;
        public PropertyTypeRepository(IConfiguration config)
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
                    string query = "Delete From PropertyTypes Where Id= @Id";
                    connection.Execute(query, new { Id = id });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<PropertyTypes>> GetPropertyTypeList()
        {
            IEnumerable<PropertyTypes> users = new List<PropertyTypes>();
            using (var connection = this.Connection)
            {
                users = await connection.QueryAsync<PropertyTypes>("SELECT Id as PropertyTypeId, Title FROM PropertyTypes");
            }
            return users.ToList();
        }

        public PropertyTypes RegisterPropertyTypes(PropertyTypes propertyTypeModel)
        {
            try
            {
                using (MySqlConnection connection = this.Connection)
                {
                    connection.Open();
                    string query = @"INSERT INTO PropertyTypes(Title) VALUES(@Title);";
                    connection.Execute(query, propertyTypeModel);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return propertyTypeModel;
        }
    }
}
