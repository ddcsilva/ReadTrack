using AutoMapper;
using ReadTrack.Entities.Models;
using ReadTrack.Shared.DataTransferObjects;

namespace ReadTrack.Service.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Author, AuthorDto>();
    }
}
