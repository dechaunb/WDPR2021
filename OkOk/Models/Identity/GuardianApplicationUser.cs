using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OkOk.Models.Identity
{
    public class GuardianApplicationUser : ApplicationUser
    {   
        [PersonalData]
        public virtual ICollection<ClientApplicationUser> Children { get; set; }
    }
}