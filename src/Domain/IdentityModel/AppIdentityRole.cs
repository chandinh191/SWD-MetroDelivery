using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.IdentityModel
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
