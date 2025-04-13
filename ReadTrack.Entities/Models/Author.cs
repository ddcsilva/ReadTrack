using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadTrack.Entities.Models;

public class Author
{
    [Column("AuthorId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O nome do autor é obrigatório.")]
    [MaxLength(60, ErrorMessage = "O nome do autor pode ter no máximo 60 caracteres.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O gênero principal é obrigatório.")]
    [MaxLength(60, ErrorMessage = "O gênero principal pode ter no máximo 60 caracteres.")]
    public string? MainGenre { get; set; }

    public string? WritingStyle { get; set; }

    public ICollection<Book>? Books { get; set; }
}
