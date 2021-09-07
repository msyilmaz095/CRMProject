using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Entities.Dto
{
    public class viewSalesOffer : SalesOffer
    {
        public string CustomerName { get; set; }
        public string CustomerContactName { get; set; }
        public string AssignedToName { get; set; }
        public string CurrencyName { get; set; }
        public string PaymentMethodName { get; set; }
    }
}
