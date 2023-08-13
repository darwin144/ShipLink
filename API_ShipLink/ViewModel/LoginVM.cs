﻿using System.ComponentModel.DataAnnotations;

namespace API_ShipLink.ViewModel
{
    public class LoginVM
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
