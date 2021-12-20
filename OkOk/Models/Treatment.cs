using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OkOk.Models.Identity;

namespace OkOk.Models
{
    public class Treatment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Datum & Tijd")]
        public DateTime DateTime { get; set; }
        [Display(Name = "Omschrijving")]
        public string Description { get; set; }

        //Foreign Keys
        public string ClientId { get; set; }
        public ClientApplicationUser ClientApplicationUser { get; set; }
        public string DoctorId { get; set; }
        public DoctorApplicationUser DoctorApplicationUser { get; set; }
    }
}