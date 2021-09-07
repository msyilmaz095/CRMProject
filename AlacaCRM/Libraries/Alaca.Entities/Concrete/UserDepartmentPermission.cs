using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class UserDepartmentPermission:IEntity
    {
        public Guid UserDepartmentPermissionId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? DepartmentId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; }
    }
}
