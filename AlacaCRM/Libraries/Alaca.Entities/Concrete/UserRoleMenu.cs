using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class UserRoleMenu:IEntity
    {
        public Guid UserRoleMenuId { get; set; }
        public Guid UserRoleId { get; set; }
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
