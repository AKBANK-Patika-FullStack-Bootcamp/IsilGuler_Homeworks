using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentServices;
        public PaymentsController(IPaymentService paymentServices)
        {
            _paymentServices = paymentServices;
        }

        [HttpGet("getall")]
        public IActionResult GetPayments()
        {
            return Ok(_paymentServices.GetPayments());
        }

        [HttpGet("{id}", Name = "GetPayment")]
        public IActionResult GetPayment(int id)
        {
            return Ok(_paymentServices.GetPayment(id));
        }

        [HttpPost("addpayment")]
        public IActionResult AddPayment(Payment payment)
        {
            _paymentServices.AddPayment(payment);
            return CreatedAtRoute("GetPayment", new { id = payment.PaymentId}, payment);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePayment(int id)
        {
            _paymentServices.DeletePayment(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdatePayment(Payment payment)
        {
            return Ok(_paymentServices.UpdatePayment(payment));
        }
    }
}
