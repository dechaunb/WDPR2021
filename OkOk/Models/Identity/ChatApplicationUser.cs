using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Interfaces;

namespace OkOk.Models.Identity
{
    public class ChatApplicationUser : ApplicationUser, IReceiver
    {
        //Foreign Keys
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<SupportGroup> SupportGroups { get; set; }
    }
}