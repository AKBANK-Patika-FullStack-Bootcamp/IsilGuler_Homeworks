using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        List<Payment> GetPayments();
        Payment GetPayment(int id);
        Payment AddPayment(Payment payment);
        void DeletePayment(int id);
        Payment UpdatePayment(Payment payment);

    }
}
