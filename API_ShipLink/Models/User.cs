using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ShipLink.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string? Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Column("phone", TypeName = "nvarchar(20)")]
        public string Phone { get; set; }
        public string Address { get; set; }
        
        public Account? Account { get; set; }
    }
}
