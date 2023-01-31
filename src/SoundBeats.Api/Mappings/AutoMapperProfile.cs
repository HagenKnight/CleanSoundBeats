using AutoMapper;
using SoundBeats.Core.DTO.Artist;
using SoundBeats.Core.DTO.Country;
using SoundBeats.Core.DTO.Genre;
using SoundBeats.Core.Entities;

namespace SoundBeats.Api.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap(); ;
            CreateMap<GenreDTOCreate, Genre>().ReverseMap();
            CreateMap<GenreDTOUpdate, Genre>().ReverseMap(); ;
            CreateMap<GenreDTODelete, Genre>().ReverseMap(); ;

            CreateMap<Country, CountryDTO>().ReverseMap(); ;

            CreateMap<Artist, ArtistDTO>().ReverseMap();
        }
    }
}
