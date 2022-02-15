using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentRequestsController:ControllerBase
    {
        private readonly IPaymentRequestService _paymentRequestServices;
        public PaymentRequestsController(IPaymentRequestService paymentRequestServices)
        {
            _paymentRequestServices = paymentRequestServices;
        }

        [HttpGet("getall")]
        public IActionResult GetPaymentRequests()
        {
            return Ok(_paymentRequestServices.GetPaymentRequests());
        }

        [HttpGet("{id}", Name = "GetPaymentRequest")]
        public IActionResult GetPaymentRequest(int id)
        {
            return Ok(_paymentRequestServices.GetPaymentRequest(id));
        }

        [HttpPost("addpaymentRequest")]
        public IActionResult AddPayment(PaymentRequest paymentRequest)
        {
            _paymentRequestServices.AddPaymentRequest(paymentRequest);
            return CreatedAtRoute("GetPaymentRequest", new { id = paymentRequest.PaymentRequestId}, paymentRequest);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePaymentRequest(int id)
        {
            _paymentRequestServices.DeletePaymentRequest(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdatePaymentRequest(PaymentRequest paymentRequest)
        {
            return Ok(_paymentRequestServices.UpdatePaymentRequest(paymentRequest));
        }
    }
}
