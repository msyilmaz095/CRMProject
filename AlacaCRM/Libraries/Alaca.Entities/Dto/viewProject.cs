using Alaca.Entities.Concrete;

namespace Alaca.Entities.Dto
{
    public class viewProject : Project
    {
        public string CustomerName { get; set; }
        public string CustomerContactName { get; set; }
        public string AssignedToName { get; set; }
        public string CurrencyName { get; set; }
        public string PaymentMethodName { get; set; }
        public string ProjectStatuName { get; set; }
    }
}
