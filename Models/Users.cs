using Microsoft.AspNetCore.Identity;

namespace IINVT.Models
{
    public class Users: IdentityUser
    {
        public string FullName { get; set; }
    }
}
