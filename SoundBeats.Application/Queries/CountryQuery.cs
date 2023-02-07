using MediatR;
using SoundBeats.Core.Custom;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities.Base;
using SoundBeats.Core.Parameters;
using SoundBeats.Core.Wrappers;

namespace SoundBeats.Application.Queries
{

    public class GetAllCountryParameter : RequestParameter { }

    public class GetAllCountryQuery : IRequest<ApiResponse<MetaData<ShapedEntityDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Fields { get; set; }
        public string Search { get; set; }
        public string OrderBy { get; set; }
        public string Route { get; set; }
    }

    public class GetCountryQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
        public GetCountryQuery(int id) => Id = id;
    }

}
