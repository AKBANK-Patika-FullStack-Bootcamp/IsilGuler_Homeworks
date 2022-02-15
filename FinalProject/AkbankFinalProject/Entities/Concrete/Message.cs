using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Message : IEntity
    {
        public int MessageId { get; set; }
        public string SenderId { get; set; }

        public string ReceiverId  { get; set; }

        public string UserMessage { get; set; }

        public bool ReadInfo { get; set; }

    }
}
