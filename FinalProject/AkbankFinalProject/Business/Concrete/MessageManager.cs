using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager:IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }


        public String Add(Message message)
        {
            _messageDal.Add(message);
            return message + "eklendi";
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message GetById(int messageId)
        {
            return _messageDal.Get(c => c.MessageId == messageId);

        }

        public String Update(Message message)
        {
            _messageDal.Update(message);
            return message + "güncellendi";

        }

        public String Delete(Message message)
        {
            _messageDal.Delete(message);
            return message + "silindi";
        }

    }
}
