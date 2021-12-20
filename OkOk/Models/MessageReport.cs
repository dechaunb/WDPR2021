using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkOk.Models
{
    public class MessageReport
    {
        //Foreign Keys
        public Guid MessageId { get; set; }
        public Message Message { get; set; }
        public Guid ReportId { get; set; }
        public Report Report { get; set; }
    }
}