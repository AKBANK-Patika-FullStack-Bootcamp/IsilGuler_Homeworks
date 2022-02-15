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
    public class AuthorityManager:IAuthorityService
    {
        IAuthorityDal _authorityDal;

        public AuthorityManager(IAuthorityDal authorityDal)
        {
            _authorityDal = authorityDal;
        }


        public String Add(Authority authority)
        {
            _authorityDal.Add(authority);
            return authority + "eklendi";
        }

        public List<Authority> GetAll()
        {
            //İş kodları
            return _authorityDal.GetAll();
        }

        public Authority GetById(int authorityId)
        {
            return _authorityDal.Get(c => c.AuthorityId == authorityId);

        }

        public String Update(Authority authority)
        {
            _authorityDal.Update(authority);
            return authority + "güncellendi";

        }

        public String Delete(Authority authority)
        {
            _authorityDal.Delete(authority);
            return authority + "silindi";
        }
    }
}
