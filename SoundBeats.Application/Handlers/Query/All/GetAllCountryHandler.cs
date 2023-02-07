using AutoMapper;
using MediatR;
using SoundBeats.Application.Queries;
using SoundBeats.Core.Custom;
using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Entities.Base;
using SoundBeats.Core.Interfaces.Management;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Core.Wrappers;
using System.Linq.Expressions;
using Utilities;

namespace SoundBeats.Application.Handlers.Query.All
{
    public class GetAllCountryHandler : IRequestHandler<GetAllCountryQuery, ApiResponse<MetaData<ShapedEntityDTO>>>
    {

        private readonly IMapper _mapper;
        private readonly IUriService _uriService;
        private readonly IModelHelper _modelHelper;
        
        private readonly ICountryService _countryService;

        public GetAllCountryHandler(ICountryService countryService, IMapper mapper, IModelHelper modelHelper, IUriService uriService) =>
            (_mapper, _uriService, _modelHelper, _countryService) = (mapper, uriService, modelHelper, countryService);

        public async Task<ApiResponse<MetaData<ShapedEntityDTO>>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Country, bool>> _expressionLambda = null;
            var _validFilter = _mapper.Map<GetAllCountryParameter>(request);

            // Filtered fields security & limit to fields in view model
            if (!string.IsNullOrEmpty(_validFilter.Fields))
                _validFilter.Fields = _modelHelper.ValidateModelFields<CountryDTO>(_validFilter.Fields);

            // Default fields from view model
            if (string.IsNullOrEmpty(_validFilter.Fields))
                _validFilter.Fields = _modelHelper.GetModelFields<CountryDTO>();

            // Create search criteria, according to the entity of the Database context.
            if (!string.IsNullOrEmpty(_validFilter.Search))
            {
                var _newFilter = new WhereFilter()
                {
                    Condition = GroupOp.OR,
                    Rules = new List<WhereFilter>()
                    {
                        new WhereFilter { Field = "nameEs", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } },
                        new WhereFilter { Field = "nameEn", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } },
                        new WhereFilter { Field = "iso2", Operator = WhereConditionsOp.Contains, Data = new[] { _validFilter.Search } }
                    }
                };
                _expressionLambda = QueryBuilder.BuildExpressionLambda<Country>(_newFilter, new BuildExpressionOptions() { ParseDatesAsUtc = false });
            }

            var _resultPaged = await _countryService.GetPagedCountries(_validFilter.PageNumber, _validFilter.PageSize, cancellationToken, _expressionLambda, _validFilter.Fields, _validFilter.OrderBy);
            return new ApiResponse<MetaData<ShapedEntityDTO>>(_mapper.Map<PagedList<ShapedEntityDTO>, MetaData<ShapedEntityDTO>>(new PagedList<ShapedEntityDTO>(_resultPaged, _validFilter.PageNumber, _validFilter.PageSize, _countryService.RowCount, _uriService, string.IsNullOrEmpty(request.Fields) ? "" : _validFilter.Fields, string.IsNullOrEmpty(request.OrderBy) ? "" : _validFilter.OrderBy, string.IsNullOrEmpty(request.Search) ? "" : _validFilter.Search, request.Route)));
        }

    }
}
