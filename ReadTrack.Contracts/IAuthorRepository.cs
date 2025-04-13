using ReadTrack.Entities.Models;

namespace ReadTrack.Contracts;

public interface IAuthorRepository
{
    IEnumerable<Author> GetAllAuthors(bool trackChanges);
}