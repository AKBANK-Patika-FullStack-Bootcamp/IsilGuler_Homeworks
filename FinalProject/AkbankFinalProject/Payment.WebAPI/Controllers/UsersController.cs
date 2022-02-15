using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly IUserService _userServices;
        public UsersController(IUserService userService)
        {
            _userServices = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetUsers()
        {
            return Ok(_userServices.GetAll());
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetUser(int id)
        {
            return Ok(_userServices.GetById(id));
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(User user)
        {
            _userServices.Add(user);
            return CreatedAtRoute("GetUser", new { id = user.UserId }, user);
        }

        [HttpDelete("deleteUser")]
        public IActionResult DeleteUser(User user)
        {
            _userServices.Delete(user);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            return Ok(_userServices.Update(user));
        }
    }
}
