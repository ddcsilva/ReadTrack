using ReadTrack.Contracts;
using ReadTrack.Entities.Models;
using ReadTrack.Service.Contracts;

internal sealed class AuthorService : IAuthorService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public AuthorService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IEnumerable<Author> GetAllAuthors(bool trackChanges)
    {
        try
        {
            var authors = _repository.Author.GetAllAuthors(trackChanges);
            return authors;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Erro em {nameof(GetAllAuthors)}: {ex}");
            throw;
        }
    }
}
