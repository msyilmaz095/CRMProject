using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Utilities
{
    public class Enums
    {
        public enum UserStatus
        {
            [Display(Name = "Aktif")]
            Aktif = 1,
            [Display(Name = "Pasif")]
            Pasif = 2
        }
    }
}
