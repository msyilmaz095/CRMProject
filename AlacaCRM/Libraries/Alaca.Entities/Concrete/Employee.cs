using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Employee : IEntity
    {
        public Guid EmployeeId { get; set; }
        public Guid? DepartmanId { get; set; }
        public Guid? PositionId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? DateOfStart { get; set; }
        public Guid? CompanyId { get; set; }
        public bool? CanLogin { get; set; }
        public bool IsActive { get; set; }
        public List<User> Users { get; set; }
    }
}
