using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository.Configuration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasData(
            new Author
            {
                Id = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "George Orwell",
                MainGenre = "Ficção",
                WritingStyle = "Narrativo"
            },
            new Author
            {
                Id = Guid.Parse("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "J. R. R. Tolkien",
                MainGenre = "Fantasia",
                WritingStyle = "Épico descritivo"
            }
        );
    }
}
