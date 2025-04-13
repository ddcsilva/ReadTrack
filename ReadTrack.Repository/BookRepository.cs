using ReadTrack.Contracts;
using ReadTrack.Entities.Models;

namespace ReadTrack.Repository;

public class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}
