using Microsoft.AspNetCore.Identity;

namespace Auth.Identity.Domain
{
    public class User : IdentityUser
    {
        public string? Initials { get; init; }
    }
}
