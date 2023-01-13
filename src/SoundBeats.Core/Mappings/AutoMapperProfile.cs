using AutoMapper;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreDTO>();
            CreateMap<GenreDTO, Genre>();

            CreateMap<Country, CountryDTO>();
            CreateMap<CountryDTO, Country>();

            CreateMap<Artist, ArtistDTO>();
            CreateMap<ArtistDTO, Artist>();
        }
    }
}
