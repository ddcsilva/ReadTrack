using ReadTrack.Contracts;
using ReadTrack.Service.Contracts;

namespace ReadTrack.Service;

internal sealed class AuthorService : IAuthorService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public AuthorService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    // Aqui virão métodos de lógica, ex: GetAllAuthors(), AddAuthor(), etc.
}
