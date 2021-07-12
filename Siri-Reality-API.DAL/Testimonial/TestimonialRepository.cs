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
    public class TestimonialRepository : ITestimonialRepository
    {
        protected readonly IConfiguration _config;
        public TestimonialRepository(IConfiguration config)
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
                    string query = "Delete From Testimonials Where Id= @Id";
                    connection.Execute(query, new { Id = id });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Testimonial>> GetTestimonialList()
        {
            IEnumerable<Testimonial> result = new List<Testimonial>();
            using (var connection = this.Connection)
            {
                result = await connection.QueryAsync<Testimonial>("SELECT Id as TestimonialId,Name,Title,FilePath,Description,CreatedDate,UpdatedDate,Types,VideoLink FROM Testimonials");
            }
            return result.ToList();
        }

        public Testimonial RegisterTestimonial(Testimonial model)
        {
            try
            {
                using (MySqlConnection connection = this.Connection)
                {
                    connection.Open();
                    string query = @"INSERT INTO Testimonials(Name,Title,FilePath,Description,CreatedDate,UpdatedDate,Types,VideoLink) 
                                    VALUES(@Name,@Title,@FilePath,@Description,@CreatedDate,@ModifiedDate,@Types,@VideoLink) ;";
                    connection.Execute(query, model);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }
    }
}
