using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasData(
            new Book
            {
                Id = Guid.Parse("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Title = "1984",
                PageCount = 328,
                Genre = "Distopia",
                AuthorId = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Book
            {
                Id = Guid.Parse("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Title = "A Revolução dos Bichos",
                PageCount = 112,
                Genre = "Sátira política",
                AuthorId = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Book
            {
                Id = Guid.Parse("bc578012-8d8f-4d57-9c65-9b4e7fba4e30"),
                Title = "O Senhor dos Anéis",
                PageCount = 1178,
                Genre = "Fantasia",
                AuthorId = Guid.Parse("3d490a70-94ce-4d15-9494-5248280c2ce3")
            }
        );
    }
}
