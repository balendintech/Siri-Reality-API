using Siri_Reality_API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.Service
{
    public interface ITestimonialService
    {
        Testimonial RegisterTestimonial(Testimonial testimonialModel);
        Task<List<Testimonial>> GetTestimonialList();
        void Delete(int id);
    }
}
