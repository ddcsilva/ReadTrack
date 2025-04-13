using Microsoft.EntityFrameworkCore;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Author>? Authors { get; set; }
    public DbSet<Book>? Books { get; set; }
}
