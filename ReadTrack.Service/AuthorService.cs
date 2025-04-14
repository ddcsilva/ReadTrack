using ReadTrack.Contracts;
using ReadTrack.Service.Contracts;
using ReadTrack.Shared.DataTransferObjects;

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

    public IEnumerable<AuthorDto> GetAllAuthors(bool trackChanges)
    {
        try
        {
            var authors = _repository.Author.GetAllAuthors(trackChanges);

            var authorsDto = authors.Select(a => new AuthorDto
            {
                Id = a.Id,
                Name = a.Name ?? string.Empty,
                MainGenre = a.MainGenre ?? string.Empty,
                WritingStyle = a.WritingStyle ?? string.Empty
            }).ToList();

            return authorsDto;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Erro na execução de {nameof(GetAllAuthors)}: {ex}");
            throw;
        }
    }
}
