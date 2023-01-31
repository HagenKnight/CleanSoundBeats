using AutoMapper;
using SoundBeats.Core.DTO.Artist;
using SoundBeats.Core.DTO.Country;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;

namespace SoundBeats.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap(); ;
            CreateMap<GenreDTOCreate, Genre>().ReverseMap();
            CreateMap<GenreDTOCreate, GenreDTO>().ReverseMap();
            CreateMap<GenreDTOUpdate, Genre>().ReverseMap(); ;
            CreateMap<GenreDTOUpdate, GenreDTO>().ReverseMap(); ;
            CreateMap<GenreDTODelete, Genre>().ReverseMap(); ;
            CreateMap<GenreDTODelete, GenreDTO>().ReverseMap(); ;

            CreateMap<Country, CountryDTO>().ReverseMap(); ;

            CreateMap<Artist, ArtistDTO>().ReverseMap();
        }
    }
}
