using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }

        public string IdentityNo { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string EmailAddress { get; set; }

        public string GsmNo { get; set; }

        public string LicensePlate { get; set; }






    }
}
