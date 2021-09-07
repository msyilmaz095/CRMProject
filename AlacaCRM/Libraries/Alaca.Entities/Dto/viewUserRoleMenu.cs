using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Entities.Dto
{
    public class viewUserRoleMenu
    {
        public Guid? UserRoleMenuId { get; set; }
        public Guid? MenuId { get; set; }
        public Guid? UserRoleId { get; set; }
        public bool IsActive { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }

    }
}
