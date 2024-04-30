using Microsoft.AspNetCore.Identity;

namespace Application.Extension.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public required string Name { get; set; }
    }
}
