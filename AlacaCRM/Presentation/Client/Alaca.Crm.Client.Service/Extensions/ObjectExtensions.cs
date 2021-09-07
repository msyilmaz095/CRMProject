using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Extensions
{
    public static class ObjectExtensions
    {
        public static Guid ObjectToGuid(this object obj)
        {
            return Guid.Parse(obj.ToString());
        }
    }
}
