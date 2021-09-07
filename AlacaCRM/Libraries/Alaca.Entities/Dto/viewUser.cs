using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Entities.Dto
{
    public class viewUser : User
    {
        public string CompanyName { get; set; }
        public string UserRoleName { get; set; }
        public string UserStatusName { get; set; }
    }
}
