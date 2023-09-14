using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.IdentityModel;

public class ApplicationUser : IdentityUser
{
    public string Fullname { get; set; }
    public DateTime BirthDay { get; set; }
    public string? Image { get; set; }

    //public virtual Employee Employee { get; set; }
  
}