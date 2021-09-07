using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Alaca.Core.Entities
{
    public abstract class UserBase : IEntity
    {
        public Guid UserId { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
        public Guid? UserRoleId { get; set; }
        public int UserStatusId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? EmployeeId { get; set; }
    }
}
