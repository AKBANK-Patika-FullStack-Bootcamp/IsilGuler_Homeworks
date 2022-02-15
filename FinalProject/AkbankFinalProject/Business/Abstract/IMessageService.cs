using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        public String Add(Message message);
        public List<Message> GetAll();
        public Message GetById(int id);
        public String Update(Message message);
        public String Delete(Message message);
    }
}
