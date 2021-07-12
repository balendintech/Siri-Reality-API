using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Siri_Reality_API.Entities;
using Siri_Reality_API.Service;
using System.Threading.Tasks;

namespace Siri_Reality_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TestimonialController:ControllerBase
    {
        protected readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult Delete(int id)
        {
            _testimonialService.Delete(id);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTestimonialList()
        {
            var results = await _testimonialService.GetTestimonialList();
            return Ok(results);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]


        public IActionResult RegisterTestimonial(Testimonial model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var resultModel = _testimonialService.RegisterTestimonial(model);
            return Ok(resultModel);
        }
    }
}
