using System.ComponentModel.DataAnnotations;

namespace Client_Shiplink.ViewModel
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string user_Type { get; set; }
        public string Phone { get; set; }
        public string? ConfirmPassword { get; set; }

    }
}
