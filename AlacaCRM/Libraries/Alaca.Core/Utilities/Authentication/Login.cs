using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Utilities.Authentication
{
    public class Login
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola boş geçilemez!")]
        public string Password { get; set; }
    }
}
