using API_ShipLink.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ShipLink.Context
{
    public class ShiplinkContext : DbContext
    {
        public ShiplinkContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<AccountRole> AccountRole { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>().HasData(new Role
            {
                Id = Guid.Parse("f147a695-1a4f-4960-bffc-08db60bf618f"),
                Name = "User"
            },
            new Role
            {
                Id = Guid.Parse("c22a20c5-0149-41fd-bffd-08db60bf618f"),
                Name = "Admin"
            }
            );
            builder.Entity<User>().HasIndex(e => new { e.Email, e.Phone }).IsUnique();

            builder.Entity<Account>().HasOne(a => a.User).WithOne(b => b.Account)
                .HasForeignKey<Account>(c => c.User_id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<AccountRole>().HasOne<Account>().WithOne(b => b.AccountRole)
                .HasForeignKey<AccountRole>(c => c.Account_id)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Role>().HasMany(a => a.AccountRoles).WithOne(b => b.Role)
                .HasForeignKey(c => c.Role_id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
