using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController:ControllerBase
    {
        private readonly IMessageService _messageServices;
        public MessagesController(IMessageService messageService)
        {
            _messageServices = messageService;
        }

        [HttpGet("getall")]
        public IActionResult GetMessages()
        {
            return Ok(_messageServices.GetAll());
        }

        [HttpGet("{id}", Name = "GetMessage")]
        public IActionResult GetMessage(int id)
        {
            return Ok(_messageServices.GetById(id));
        }

        [HttpPost("addMessage")]
        public IActionResult AddMessage(Message message)
        {
            _messageServices.Add(message);
            return CreatedAtRoute("GetMessage", new { id = message.MessageId }, message);
        }

        [HttpDelete("deleteMessage")]
        public IActionResult DeleteMessage(Message message)
        {
            _messageServices.Delete(message);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateMessage(Message message)
        {
            return Ok(_messageServices.Update(message));
        }
    }
}
