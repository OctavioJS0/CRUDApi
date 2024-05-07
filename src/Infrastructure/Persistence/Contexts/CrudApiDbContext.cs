using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;

public class CrudApiDbContext : DbContext
{
    public CrudApiDbContext(DbContextOptions options) : base(options)
    {
        
    }

    private DbSet<Authors> Authors { get; set; }
    private DbSet<Books> Books { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CrudApiDbContext).Assembly);
        
        modelBuilder.Entity<Authors>()
            .HasMany(e => e.Books)
            .WithMany(e => e.Authors);

        modelBuilder.Entity<Books>()
            .HasMany(e => e.Authors)
            .WithMany(e => e.Books);
    }

}