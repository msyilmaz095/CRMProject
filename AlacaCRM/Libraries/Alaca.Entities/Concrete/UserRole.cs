using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class UserRole : IEntity
    {
        public Guid UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
