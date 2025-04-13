using ReadTrack.Contracts;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository;

public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
