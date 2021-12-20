using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OkOk.Models.Identity
{
    public class ClientApplicationUser : ChatApplicationUser
    {
        [PersonalData]
        public bool OldEnough { get; set; }
        [PersonalData]
        [Required]
        public Address Address { get; set; }

        [PersonalData]
        public virtual ICollection<Treatment> Treatments { get; set; }
        [PersonalData]
        public virtual ICollection<GuardianApplicationUser> Guardians { get; set; }
        [PersonalData]
        public SignUpRequest SignUpRequest { get; set; }
    }
}