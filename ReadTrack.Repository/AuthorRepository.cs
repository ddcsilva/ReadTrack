using ReadTrack.Contracts;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository;

public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    public IEnumerable<Author> GetAllAuthors(bool trackChanges) => 
        FindAll(trackChanges)
            .OrderBy(a => a.Name)
            .ToList();
}
