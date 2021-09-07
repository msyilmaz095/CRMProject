using Alaca.Crm.Client.Service.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Pages.Customers
{
    public partial class CustomerContactRecord
    {
        [Parameter] public Action<bool> OnShowActivityPageChange { get; set; }
        [Parameter] public Contact contact { get; set; }
        protected Department[] departments;
        protected Entities.Concrete.Position[] positions;
        protected ContactStatu[] contactStatus;
        protected ContactType[] contactTypes;
        protected CustomerLocation[] customerLocations;
        [Inject] IContactService _contactService { get; set; }
        [Inject] IContactTypeService _contactTypeService { get; set; }
        [Inject] IPositionService _positionService { get; set; }
        [Inject] IContactStatuService _contactStatuService { get; set; }
        [Inject] IDepartmentService _departmentService { get; set; }
        [Inject] ICustomerLocationService _customerLocationService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            customerLocations = (await _customerLocationService.GetLocationByCustomerIdAll(contact.CustomerId)).Data;
            positions = (await _positionService.GetAll()).Data;
            departments = (await _departmentService.GetAll()).Data;
            contactStatus = (await _contactStatuService.GetAll()).Data;
            contactTypes = (await _contactTypeService.GetAll()).Data;
        }

        protected async void SaveContact()
        {
            if (contact.ContactId == Guid.Empty)
            {
                await _contactService.Insert(contact);
            }
            else
            {
                await _contactService.Update(contact);
            }
            OnShowActivityPageChange?.Invoke(false);
        }

        protected void Close()
        {
            OnShowActivityPageChange?.Invoke(false);
        }
    }
}
