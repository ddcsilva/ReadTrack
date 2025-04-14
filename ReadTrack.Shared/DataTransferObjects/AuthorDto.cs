namespace ReadTrack.Shared.DataTransferObjects;

public record AuthorDto
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public string? MainGenre { get; init; }
    public string? WritingStyle { get; init; }
}
