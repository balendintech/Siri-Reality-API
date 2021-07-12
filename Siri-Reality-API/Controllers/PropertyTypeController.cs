using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Siri_Reality_API.Entities;
using Siri_Reality_API.Service;
using System.Threading.Tasks;

namespace Siri_Reality_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PropertyTypeController:ControllerBase
    {
        protected readonly IPropertyTypeService _propertyTypeService;
        public PropertyTypeController(IPropertyTypeService propertyTypeService)
        {
            _propertyTypeService = propertyTypeService;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult Delete(int id)
        {
            _propertyTypeService.Delete(id);
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPropertyTypeList()
        {
            var results = await _propertyTypeService.GetPropertyTypeList();
            return Ok(results);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]


        public IActionResult RegisterPropertyTypes(PropertyTypes propertyTypeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var model = _propertyTypeService.RegisterPropertyTypes(propertyTypeModel);
            return Ok(model);
        }
    }
}
