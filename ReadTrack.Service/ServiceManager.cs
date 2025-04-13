using ReadTrack.Service.Contracts;
using ReadTrack.Contracts;

namespace ReadTrack.Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IAuthorService> _authorService;
    private readonly Lazy<IBookService> _bookService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _authorService = new Lazy<IAuthorService>(() => new AuthorService(repositoryManager, logger));
        _bookService = new Lazy<IBookService>(() => new BookService(repositoryManager, logger));
    }

    public IAuthorService AuthorService => _authorService.Value;
    public IBookService BookService => _bookService.Value;
}
