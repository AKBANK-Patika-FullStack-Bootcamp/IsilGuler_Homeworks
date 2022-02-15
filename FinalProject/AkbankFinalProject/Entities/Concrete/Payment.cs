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
    public class Payment : IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int PaymentId { get; set; }

        [BsonElement("Payment_Number")]
        public string PaymentNumber { get; set; }

        [BsonElement("Payment_Item")]
        public string PaymentItem { get; set; }

        [BsonElement("Price")]
        public double Price { get; set; }

        [BsonElement("User_Id ")]
        public int UserId { get; set; }

        [BsonElement("Payment_Date")]
        public DateTime PaymentDate { get; set; }

        [BsonElement("Payment_State")]
        public bool PaymentState { get; set; }

        [BsonElement("Conservation_Id")]
        public string ConservationId { get; set; }

    }
}
