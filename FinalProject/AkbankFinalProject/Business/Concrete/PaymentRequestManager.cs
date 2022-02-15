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
    public class PaymentRequestManager:IPaymentRequestService
    {
        private readonly IMongoCollection<PaymentRequest> _paymentRequests;

        public PaymentRequestManager(IPaymentDBSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);

            _paymentRequests = database.GetCollection<PaymentRequest>(settings.PaymentRequestCollectionName);
        }

        public PaymentRequest AddPaymentRequest(PaymentRequest paymentRequest)
        {
            _paymentRequests.InsertOne(paymentRequest);
            return paymentRequest;
        }

        public void DeletePaymentRequest(int id)
        {
            _paymentRequests.DeleteOne(paymentRequest => paymentRequest.PaymentRequestId == id);
        }

        public PaymentRequest GetPaymentRequest(int id) => _paymentRequests.Find(paymentRequest => paymentRequest.PaymentRequestId == id).First();

        public List<PaymentRequest> GetPaymentRequests() => _paymentRequests.Find(paymentRequest => true).ToList();

        public PaymentRequest UpdatePaymentRequest(PaymentRequest paymentRequest)
        {
            GetPaymentRequest(paymentRequest.PaymentRequestId);
            _paymentRequests.ReplaceOne(p => p.PaymentRequestId == paymentRequest.PaymentRequestId, paymentRequest);
            return paymentRequest;
        }
    }
}
