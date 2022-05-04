
using Microsoft.AspNetCore.Identity;

namespace Travel_V1.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
