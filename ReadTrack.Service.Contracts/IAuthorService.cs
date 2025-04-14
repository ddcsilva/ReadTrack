using ReadTrack.Shared.DataTransferObjects;

namespace ReadTrack.Service.Contracts;

public interface IAuthorService
{
    IEnumerable<AuthorDto> GetAllAuthors(bool trackChanges);
}
