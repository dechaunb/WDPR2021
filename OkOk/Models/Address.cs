using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using OkOk.Models.Identity;

namespace OkOk.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Huisnummer")]
        public int HouseNumber { get; set; }
        [Display(Name = "Toevoeging")]
        public string HouseNumberAddition { get; set; }
        [Required]
        [Display(Name = "Straat")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "Stad")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Postcode")]
        [RegularExpression(@"^(?:NL-)?(\d{4})\s*([A-Z]{2})$", 
         ErrorMessage = "Tekens niet toegestaan.")]
        public string ZipCode { get; set; }
        [Required]
        [Display(Name = "Land")]
        public string Country { get; set; }
        public ClientApplicationUser ClientApplicationUser { get; set; }

        public string GetHouseNumber()
        {
            string result = HouseNumber + "-" + HouseNumberAddition;
            return result;
        }
    }
}