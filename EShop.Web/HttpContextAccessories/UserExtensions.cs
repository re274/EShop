using System;
using System.Linq;
using System.Security.Claims;

namespace EShop.Web.HttpContextAccessories
{
    public static class UserExtensions
    {
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            var identifier = principal.Claims.SingleOrDefault(s => s.Type == ClaimTypes.NameIdentifier);
            if (identifier != null)
            {
                return Convert.ToInt32(identifier.Value);
            }
            return default(int);
        }
    }
}
