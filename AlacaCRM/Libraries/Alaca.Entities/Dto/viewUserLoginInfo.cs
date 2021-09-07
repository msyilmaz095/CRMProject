using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Entities.Concrete;

namespace Alaca.Entities.Dto
{
    public class viewUserLoginInfo : UserLoginInfo
    {
        public string UserName { get; set; }
    }
}
