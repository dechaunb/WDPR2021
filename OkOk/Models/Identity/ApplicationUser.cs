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
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
         ErrorMessage = "Tekens niet toegestaan.")]
        public string FirstName { get; set; }
        [PersonalData]
        [Required]
        [Display(Name = "Achternaam")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
         ErrorMessage = "Tekens niet toegestaan.")]
        public string LastName { get; set; }

        public string LockedOutReason{get; set;}
    }
}