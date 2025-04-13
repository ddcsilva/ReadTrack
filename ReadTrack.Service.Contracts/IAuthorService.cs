using ReadTrack.Entities.Models;

namespace ReadTrack.Service.Contracts;

public interface IAuthorService
{
    IEnumerable<Author> GetAllAuthors(bool trackChanges);
}
