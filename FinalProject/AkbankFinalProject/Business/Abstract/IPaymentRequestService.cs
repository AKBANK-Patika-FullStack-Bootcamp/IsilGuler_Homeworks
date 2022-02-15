using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentRequestService
    {
        List<PaymentRequest> GetPaymentRequests();
        PaymentRequest GetPaymentRequest(int id);
        PaymentRequest AddPaymentRequest(PaymentRequest paymentRequest);
        void DeletePaymentRequest(int id);
        PaymentRequest UpdatePaymentRequest(PaymentRequest paymentRequest);
    }
}
