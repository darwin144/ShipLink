using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ShipLink.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("user_id")]
        public Guid User_id { get; set; }

        public User? User { get; set; }
        public AccountRole? AccountRole { get; set; }
    }
}
