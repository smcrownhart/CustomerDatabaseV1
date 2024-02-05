using CustomerDatabase.Server.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerDatabase.Server.Data;

public class CustomerDatabaseServerContext : IdentityDbContext<CustomerDatabaseServerUser>
{
    //public DbSet<CustomerDatabase> customerDatabases { get; set; }  
    public CustomerDatabaseServerContext(DbContextOptions<CustomerDatabaseServerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
