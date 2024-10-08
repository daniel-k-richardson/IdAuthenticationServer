using IdAuthenticationServer.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace IdAuthenticationServer.Persistence.ContextConfiguration;

public class IdAuthContext(DbContextOptions<IdAuthContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}


