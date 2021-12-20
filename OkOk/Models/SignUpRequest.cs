using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Models.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkOk.Models
{
    public class SignUpRequest
    {
        [Key]
        public Guid Id { get; set; }
        public bool Handled { get; set; }

    	//Foreign Keys
        public string ClientId { get; set; }
        public ClientApplicationUser ClientApplicationUser { get; set; }
        public string DoctorId { get; set; }
        public DoctorApplicationUser DoctorApplicationUser { get; set; }
    }
}