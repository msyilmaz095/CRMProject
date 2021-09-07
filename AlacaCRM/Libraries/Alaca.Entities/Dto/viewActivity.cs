using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Entities.Concrete;

namespace Alaca.Entities.Dto
{
    public class viewActivity : Activity
    {
        public string ActivityTypeName { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public string ProjectName { get; set; }
        public string ContactName { get; set; }
        public string CreateUserName { get; set; }
        public string UpdateUserName { get; set; }
    }
}
