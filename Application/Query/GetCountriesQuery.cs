using Encinecarlos.CountryPedia.Application.Dtos;
using MediatR;

namespace Encinecarlos.CountryPedia.Application.Query
{
    public class GetCountriesQuery : IRequest<List<GetCountries>>
    {
        public string? Name { get; set; }
        public string? CapitalName { get; set; }
        public string? SubRegion { get; set; }
    }
}