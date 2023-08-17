using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ShipLink.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Column("phone", TypeName = "nvarchar(20)")]
        public string Phone { get; set; }
        public string Country { get; set; } 
        public string User_Type { get; set; }


        public Account? Account { get; set; }
    }
}
