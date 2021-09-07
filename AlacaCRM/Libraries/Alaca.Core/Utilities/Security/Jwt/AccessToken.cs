using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid? UserRoleId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
