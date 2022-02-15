using Entities.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonIgnoreExtraElements]
    public class PaymentRequest : IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PaymentRequestId { get; set; }

        [BsonElement("Customer_Id")]
        public int CustomerId { get; set; }

        [BsonElement("Payment_Item")]
        public string PaymentItem { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }

        [BsonElement("Payment_Type")]
        public bool PaymentType { get; set; }

        [BsonElement("Feedback")]
        public string Feedback { get; set; }    

 
    }
}
