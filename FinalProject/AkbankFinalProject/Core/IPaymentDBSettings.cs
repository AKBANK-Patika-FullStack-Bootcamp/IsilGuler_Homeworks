using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IPaymentDBSettings
    {
        public string PaymentCollectionName { get; set; }

        public string PaymentRequestCollectionName { get; set; }
        public string ConnectionString { get; set; }    
        public string DatabaseName { get; set; }


    }
}
