using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class User : UserBase
    {
        [NotMapped]
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public Employee Employee { get; set; }
        public IList<UserDepartmentPermission> UserDepartmentPermissions { get; set; } = new List<UserDepartmentPermission>();
        //public bool IsMobileUser { get; set; }
    }
}
