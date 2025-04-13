using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReadTrack.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "MainGenre", "Name", "WritingStyle" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Fantasia", "J. R. R. Tolkien", "Épico descritivo" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Ficção", "George Orwell", "Narrativo" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Genre", "PageCount", "Title" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Distopia", 328, "1984" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Sátira política", 112, "A Revolução dos Bichos" },
                    { new Guid("bc578012-8d8f-4d57-9c65-9b4e7fba4e30"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Fantasia", 1178, "O Senhor dos Anéis" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("bc578012-8d8f-4d57-9c65-9b4e7fba4e30"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
