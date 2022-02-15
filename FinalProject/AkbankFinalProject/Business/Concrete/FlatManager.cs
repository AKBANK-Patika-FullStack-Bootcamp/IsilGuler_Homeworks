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
    public class FlatManager:IFlatService
    {
        IFlatDal _flatDal;

        public FlatManager(IFlatDal flatDal)
        {
            _flatDal = flatDal;
        }


        public String Add(Flat flat)
        {
            _flatDal.Add(flat);
            return flat + "eklendi";
        }

        public List<Flat> GetAll()
        {
            //İş kodları
            return _flatDal.GetAll();
        }

        public Flat GetById(int flatNo)
        {
            return _flatDal.Get(c => c.FlatNo == flatNo);

        }

        public String Update(Flat flat)
        {
            _flatDal.Update(flat);
            return flat + "güncellendi";

        }

        public String Delete(Flat flat)
        {
            _flatDal.Delete(flat);
            return flat + "silindi";
        }
    }
}
