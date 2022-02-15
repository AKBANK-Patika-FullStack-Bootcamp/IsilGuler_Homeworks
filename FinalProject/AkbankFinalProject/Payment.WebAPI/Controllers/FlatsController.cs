using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlatsController:ControllerBase
    {
        private readonly IFlatService _flatServices;
        public FlatsController(IFlatService flatService)
        {
            _flatServices = flatService;
        }

        [HttpGet("getall")]
        public IActionResult GetFlats()
        {
            return Ok(_flatServices.GetAll());
        }

        [HttpGet("{id}", Name = "GetFlat")]
        public IActionResult GetFlat(int id)
        {
            return Ok(_flatServices.GetById(id));
        }

        [HttpPost("addflat")]
        public IActionResult AddFlat(Flat flat)
        {
            _flatServices.Add(flat);
            return CreatedAtRoute("GetFlat", new { id = flat.FlatId }, flat);
        }

        [HttpDelete("deleteFlat")]
        public IActionResult DeleteFlat(Flat flat)
        {
            _flatServices.Delete(flat);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateFlat(Flat flat)
        {
            return Ok(_flatServices.Update(flat));
        }
    }
}
