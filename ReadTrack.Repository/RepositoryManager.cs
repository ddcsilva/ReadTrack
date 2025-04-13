using ReadTrack.Contracts;

namespace ReadTrack.Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IAuthorRepository> _authorRepository;
    private readonly Lazy<IBookRepository> _bookRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(repositoryContext));
        _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
    }

    public IAuthorRepository Author => _authorRepository.Value;
    public IBookRepository Book => _bookRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}
