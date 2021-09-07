using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using MudBlazor;
using Alaca.Entities.Concrete;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Abstract;
using System;
using Alaca.Core.Utilities.Result;

namespace Alaca.Crm.Client.Pages.Employees
{
    public partial class Employees
    {
        [Inject] IEmployeeService _employeeService { get; set; }
        [Inject] IDepartmentService _departmentService { get; set; }
        [Inject] IUserService _userService { get; set; }
        [Inject] IUserRoleService _userRoleService { get; set; }
        [Inject] IPositionService _positionService { get; set; }
        public Employee[] lstData;
        public Department[] lstDepartments;
        public Entities.Concrete.Position[] lstPosition;
        public Employee data = new Employee();
        public User dataUser = new User();
        public UserRole[] userRoles;
        protected Blazorise.Modal modalRef;
        bool _IsKullaniciCreate = false;
        public bool IsKullaniciCreate
        {
            get
            {
                if (dataUser != null && dataUser.UserId != Guid.Empty) _IsKullaniciCreate = true;
                return _IsKullaniciCreate;
            }
            set { _IsKullaniciCreate = value; }
        }
        protected override async Task OnInitializedAsync()
        {
            userRoles = (await _userRoleService.GetAll()).Data;
            lstPosition = (await _positionService.GetAll()).Data;
            lstDepartments = (await _departmentService.GetAll()).Data;
            await GetAll();
        }

        protected async Task GetAll()
        {
            var response = await _employeeService.GetAll();
            lstData = response.Data;
        }

        protected void New()
        {
            dataUser = new User();
            data = new Employee();
            modalRef.Show();
        }

        protected async Task Get(Guid id)
        {
            dataUser = (await _userService.GetByEmployeeId(id)).Data;
            data = (await _employeeService.GetById(id)).Data;
            modalRef.Show();
        }

        protected async Task Delete()
        {
            var result = await _employeeService.Delete(data.EmployeeId);
            await Result(result);
        }

        protected async Task OnValidSubmit()
        {
            IResult result;
            if (data.EmployeeId == Guid.Empty)
            {
                result = await _employeeService.Insert(data);
                if (result.Success && IsKullaniciCreate)
                {
                    await _userService.Insert(new User()
                    {
                        UserName = data.Name + " " + data.Surname,
                        EmployeeId = Guid.Parse(result.RecordId.ToString()),
                        Email = data.Email,
                        Password = dataUser.Password,
                        UserCode = data.Email,
                        UserStatusId = 1,
                        UserRoleId = dataUser.UserRoleId
                    });
                }
            }
            else
            {
                result = await _employeeService.Update(data);
                if (result.Success)
                    await _userService.Update(dataUser);
            }
            await Result(result);
        }

        private async Task Result(IResult result)
        {
            if (!result.Success)
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Error);
            }
            else
            {
                _snackBar.Add(result.Message, MudBlazor.Severity.Success);
                modalRef.Hide();
                await GetAll();
            }
        }
    }
}
