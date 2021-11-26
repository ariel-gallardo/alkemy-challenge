using Microsoft.AspNetCore.Identity;

namespace alkemy_challenge.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
