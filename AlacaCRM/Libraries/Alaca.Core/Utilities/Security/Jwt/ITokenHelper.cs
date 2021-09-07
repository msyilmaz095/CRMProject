using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Alaca.Core.Entities;

namespace Alaca.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(UserBase user, List<MenuBase> operationClaims);
        //AccessToken CreateToken(UserBase user, List<OperationClaim> operationClaims);
    }
}
