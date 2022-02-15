using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface IAuthorityService
    {
        public String Add(Authority authority);
        public List<Authority> GetAll();
        public Authority GetById(int id);
        public String Update(Authority authority);
        public String Delete(Authority authority);
    }
}
