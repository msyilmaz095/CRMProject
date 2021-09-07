using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Customers
{
    public class CustomersBase : ComponentBase
    {
        [Inject] protected ICustomerService _customerService { get; set; }
        protected List<Customer> lstData;
        public CustomersBase()
        {
        }
    }
}
