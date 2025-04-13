using ReadTrack.Contracts;
using ReadTrack.Service.Contracts;

namespace ReadTrack.Service;

internal sealed class BookService : IBookService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public BookService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}
