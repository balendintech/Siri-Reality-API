using Siri_Reality_API.Entities;
using Siri_Reality_API.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Siri_Reality_API.Service
{
    public class TestimonialService : ITestimonialService
    {
        protected readonly ITestimonialRepository _testimonialRepository;
        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void Delete(int id)
        {
            _testimonialRepository.Delete(id);
        }

        public Task<List<Testimonial>> GetTestimonialList()
        {
            return _testimonialRepository.GetTestimonialList();
        }
        public Testimonial RegisterTestimonial(Testimonial testimonialModel)
        {
            return _testimonialRepository.RegisterTestimonial(testimonialModel);
        }
    }
}
