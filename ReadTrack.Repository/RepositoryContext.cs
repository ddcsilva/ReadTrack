using Microsoft.EntityFrameworkCore;
using ReadTrack.Entities.Models;
using ReadTrack.Repository.Configuration;

namespace ReadTrack.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Author>? Authors { get; set; }
    public DbSet<Book>? Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
    }
}
