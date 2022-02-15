using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthoritiesController:ControllerBase
    {
        private readonly IAuthorityService _authorityServices;
        public AuthoritiesController(IAuthorityService authorityService)
        {
            _authorityServices = authorityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAuthorities()
        {
            return Ok(_authorityServices.GetAll());
        }

        [HttpGet("{id}", Name = "GetAuthority")]
        public IActionResult GetAuthority(int id)
        {
            return Ok(_authorityServices.GetById(id));
        }

        [HttpPost("addAuthority")]
        public IActionResult AddAuthority(Authority authority)
        {
            _authorityServices.Add(authority);
            return CreatedAtRoute("GetAuthority", new { id = authority.AuthorityId}, authority);
        }

        [HttpDelete("deleteAuthority")]
        public IActionResult DeleteAuthority(Authority authority)
        {
            _authorityServices.Delete(authority);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateAuthority(Authority authority)
        {
            return Ok(_authorityServices.Update(authority));
        }
    }
}
