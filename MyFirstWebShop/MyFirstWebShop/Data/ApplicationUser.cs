using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWebShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string? FName { get; set; }

        [StringLength(50)]
        public string? LName { get; set; }

    }

}
