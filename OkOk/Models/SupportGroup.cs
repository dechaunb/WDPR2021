using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using OkOk.Interfaces;

namespace OkOk.Models
{
    public class SupportGroup : IReceiver
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Groepnaam")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Groepsomschrijving")]
        public string Description { get; set; }

    	//Foreign Keys
        public Guid ChatUserId { get; set; }
        public virtual ICollection<ChatApplicationUser> ChatApplicationUsers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}