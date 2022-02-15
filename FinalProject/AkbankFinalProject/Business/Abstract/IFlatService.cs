using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFlatService
    {
        public String Add(Flat flat);
        public List<Flat> GetAll();
        public Flat GetById(int id);
        public String Update(Flat flat);
        public String Delete(Flat flat);
    }
}
