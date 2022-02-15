using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Flat:IEntity
    {
        public int FlatId { get; set; }

        public string BlockName { get; set; }

        public string UserStatus { get; set; }  

        public string TypeRooms { get; set; }    

        public int Floor { get; set; }    

        public int FlatNo  { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public double SubscriptionPrice { get; set; }

        public double WaterPrice    { get; set; }

        public double ElectricityPrice  { get; set; }

        public double NaturalGasPrice { get; set; }

        public bool AllPaid { get; set; }

        //Tüm faturalar ödendiyse true, değilse false


    }
}
