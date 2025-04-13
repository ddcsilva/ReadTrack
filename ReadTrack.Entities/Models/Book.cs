using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadTrack.Entities.Models;

public class Book
{
    [Column("BookId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O título do livro é obrigatório.")]
    [MaxLength(30, ErrorMessage = "O título pode ter no máximo 30 caracteres.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "O número de páginas é obrigatório.")]
    public int PageCount { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [MaxLength(20, ErrorMessage = "O gênero pode ter no máximo 20 caracteres.")]
    public string? Genre { get; set; }

    [ForeignKey(nameof(Author))]
    public Guid AuthorId { get; set; }

    public Author? Author { get; set; }
}
