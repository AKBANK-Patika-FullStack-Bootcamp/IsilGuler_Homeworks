using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Authority : IEntity
    {
        public int AuthorityId { get; set; }

        public string AuthorityName { get; set; }

        public string AuthoritySurname { get; set; }

        public string GsmNo { get; set; }
    }
}
