using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OkOk.Models.Identity
{
    public class DoctorApplicationUser : ChatApplicationUser
    {
        [PersonalData]
        [Required]
        [Display(Name = "Specialisme")]
        public string Specialism { get; set; }

        [PersonalData]
        public virtual ICollection<Treatment> Treatments { get; set; }
        [PersonalData]
        public virtual ICollection<SignUpRequest> SignUpRequests { get; set; }
        
    }
}