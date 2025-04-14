using AutoMapper;
using ReadTrack.Contracts;
using ReadTrack.Service.Contracts;
using ReadTrack.Shared.DataTransferObjects;

namespace ReadTrack.Service;

internal sealed class AuthorService : IAuthorService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public AuthorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<AuthorDto> GetAllAuthors(bool trackChanges)
    {
        try
        {
            var authors = _repository.Author.GetAllAuthors(trackChanges);
            var authorsDto = _mapper.Map<IEnumerable<AuthorDto>>(authors);

            return authorsDto;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Erro na execução de {nameof(GetAllAuthors)}: {ex}");
            throw;
        }
    }
}
