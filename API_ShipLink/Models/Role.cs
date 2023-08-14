using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_ShipLink.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Column("name", TypeName = "varchar(20)")]
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<AccountRole>? AccountRoles { get; set; }
    }
}
