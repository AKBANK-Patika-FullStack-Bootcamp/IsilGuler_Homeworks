using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        public String Add(User user);
        public List<User> GetAll();
        public User GetById(int id);
        public String Update(User user);
        public String Delete(User user);

    }
}
