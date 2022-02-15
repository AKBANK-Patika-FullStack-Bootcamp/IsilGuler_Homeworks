using Business.Abstract;
using Core;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager:IPaymentService
    {
        private readonly IMongoCollection<Payment> _payments;

        public PaymentManager(IPaymentDBSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);

            _payments = database.GetCollection<Payment>(settings.PaymentCollectionName);
        }

        public Payment AddPayment(Payment payment)
        {
            _payments.InsertOne(payment);
            return payment;
        }

        public void DeletePayment(int id)
        {
            _payments.DeleteOne(payment => payment.PaymentId == id);
        }

        public Payment GetPayment(int id) => _payments.Find(payment => payment.PaymentId == id).First();

        public List<Payment> GetPayments() => _payments.Find(payment => true).ToList();

        public Payment UpdatePayment(Payment payment)
        {
            GetPayment(payment.PaymentId);
            _payments.ReplaceOne(p => p.PaymentId == payment.PaymentId, payment);
            return payment;
        }
    }
}
