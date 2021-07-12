using Siri_Reality_API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Siri_Reality_API.DAL
{
    public interface ITestimonialRepository 
    {
        Testimonial RegisterTestimonial(Testimonial testimonialModel);
        Task<List<Testimonial>> GetTestimonialList();
        void Delete(int id);
    }
}
