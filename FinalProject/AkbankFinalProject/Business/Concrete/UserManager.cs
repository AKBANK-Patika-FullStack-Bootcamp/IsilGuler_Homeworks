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
    // İş kodları yazılacak.
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public String Add(User user)
        {
            _userDal.Add(user);
            return user + "eklendi";
        }

        public List<User> GetAll()
        {
            //İş kodları
            return _userDal.GetAll();
        }

        //Select * from Categories where CategoryId = 3
        public User GetById(int userId)
        {
            return _userDal.Get(c => c.UserId == userId);

        }

        public String Update(User user)
        {

            _userDal.Update(user);
            return user + "güncellendi";

        }

        public String Delete(User user)
        {
            _userDal.Delete(user);
            return user + "silindi";
        }

        



    }
}