using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_ShipLink.Models
{
    public class AccountRole
    {
        [Key]
        public Guid Id { get; set; }
        [Column("account_id")]
        public Guid Account_id { get; set; }
        [Column("role_id")]
        public Guid Role_id { get; set; }

        public Role? Role { get; set; }
        public Account? Account { get; set; }
    }
}
