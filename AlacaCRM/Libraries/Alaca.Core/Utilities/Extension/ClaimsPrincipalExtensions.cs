using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Core.Utilities.Extension
{
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
        public static List<string> ClaimName(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Name);
        }
        public static List<string> ClaimNameIdentifier(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.NameIdentifier);
        }
        public static Guid GetClaimNameIdentifier(this IHttpContextAccessor httpContextAccessor)
        {
          return  Guid.Parse(httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == System.Security.Claims.ClaimTypes.NameIdentifier).Value);
        }
    }
}
