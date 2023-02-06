using AutoMapper;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;

namespace SoundBeats.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreDTO>().ReverseMap(); ;
            CreateMap<CreateGenreDTO, Genre>().ReverseMap();
            CreateMap<CreateGenreDTO, GenreDTO>().ReverseMap();
            CreateMap<GenreDTOUpdate, Genre>().ReverseMap(); ;
            CreateMap<GenreDTOUpdate, GenreDTO>().ReverseMap(); ;
            CreateMap<DeleteGenreDTO, Genre>().ReverseMap(); ;
            CreateMap<DeleteGenreDTO, GenreDTO>().ReverseMap(); ;

            CreateMap<Country, CountryDTO>().ReverseMap(); ;

            CreateMap<Artist, ArtistDTO>().ReverseMap();
            CreateMap<Artist, CreateArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, CreateArtistDTO>().ReverseMap();
            CreateMap<Artist, UpdateArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, UpdateArtistDTO>().ReverseMap();
            CreateMap<Artist, DeleteArtistDTO>().ReverseMap();
            CreateMap<ArtistDTO, DeleteArtistDTO>().ReverseMap();
        }
    }
}
