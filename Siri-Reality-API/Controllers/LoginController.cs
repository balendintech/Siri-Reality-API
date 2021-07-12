using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Siri_Reality_API.Entities;
using Siri_Reality_API.Service;
using System.Threading.Tasks;


namespace Siri_Reality_API.Controllers
{
    //[ApiController]
    //[Route("api/v1/[controller]")]
    //public class LoginController:ControllerBase
    //{
    //    protected readonly IUserService _userService;
    //    public LoginController(IUserService userService)
    //    {
    //        _userService = userService;
    //    }

    //    [HttpGet]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public async Task<IActionResult> GetUserList()
    //    {
    //        var results = await _userService.GetUsersList();
    //        return Ok(results);
    //    }

    //    [Route("[action]")]
    //    [HttpGet]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public async Task<IActionResult> EmailExists(string email)
    //    {
    //        var result = await _userService.EmailExists(email);
    //        return Ok(result);
    //    }

    //    [Route("[action]")]
    //    [HttpGet]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public IActionResult ValidateUser(string Mobile, string password)
    //    {
    //        var result = _userService.ValidateUser(Mobile, password);
    //        return Ok(result);
    //    }

    //    [HttpPost]
    //    [ProducesResponseType(StatusCodes.Status201Created)]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public IActionResult RegisterUser([FromBody] User model)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        var userModel =_userService.RegisterUser(model);
    //        return Ok(userModel);
    //    }

    //    [HttpPut]
    //    [ProducesResponseType(StatusCodes.Status201Created)]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public IActionResult UpdatePassword([FromBody] User entity)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }
    //        _userService.UpdatePassword(entity);
    //        return Ok();
    //    }

    //    [HttpDelete]
    //    [ProducesResponseType(StatusCodes.Status200OK)]
    //    public IActionResult DeleteUser(int id)
    //    {
    //        _userService.Delete(id);
    //        return Ok();
    //    }
    //}
}
