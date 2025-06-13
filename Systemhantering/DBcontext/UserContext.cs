using Microsoft.EntityFrameworkCore;
using Systemhantering.Model;

namespace Systemhantering.DBcontext;
public class UserAuthContext : DbContext
{
    public UserAuthContext(DbContextOptions<UserAuthContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique(); 

        base.OnModelCreating(modelBuilder);
    }
}


