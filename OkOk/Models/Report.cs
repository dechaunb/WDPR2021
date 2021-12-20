using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OkOk.Models.Identity;

namespace OkOk.Models
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }

        //Foreign keys
        public MessageReport MessageReport { get; set; }
    }
}