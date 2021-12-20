using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OkOk.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [PersonalData]
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
    }
}