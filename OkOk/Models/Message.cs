using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkOk.Models
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

    	//Foreign Keys
        public string SenderId { get; set; }
        public ChatApplicationUser Sender { get; set; }
        public Guid GroupId { get; set; }
        public SupportGroup SupportGroup { get; set; }

        public virtual ICollection<MessageReport> MessageReports { get; set; }
    }
}