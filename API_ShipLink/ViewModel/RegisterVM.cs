using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ShipLink.ViewModel
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }        
        public string Phone { get; set; }
        public string User_Type { get; set; }
        public string? Country { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
