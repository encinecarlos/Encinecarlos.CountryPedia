using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encinecarlos.CountryPedia.Application.Dtos;
using Encinecarlos.CountryPedia.Application.specification;
using Encinecarlos.CountryPedia.Domain.Entities;
using Encinecarlos.CountryPedia.Infrastructure.Interfaces;
using MediatR;

namespace Encinecarlos.CountryPedia.Application.Query
{
    public class GetCountriesHandler : IRequestHandler<GetCountriesQuery, List<GetCountries>>
    {
        private IHttpService clientService { get; }

        public GetCountriesHandler(IHttpService clientService)
        {
            this.clientService = clientService;
        }

        public async Task<List<GetCountries>> Handle(
            GetCountriesQuery request,
            CancellationToken cancellationToken
        )
        {
            List<GetCountries> countryList = new();

            var response = await clientService.GetAllCountries();

            if (!string.IsNullOrEmpty(request.Name) || !string.IsNullOrEmpty(request.SubRegion))
            {
                var filterByName = new CountryNameSpecification(request.Name);
                var filterBySubRegion = new CountryBySubRegion(request.SubRegion);
                var countryFiltered = response.Where(c => filterByName.IsSatisfiedBy(c)).Where(c => filterBySubRegion.IsSatisfiedBy(c));
                GetFilterList(countryList, countryFiltered);
            }
            // else if (!string.IsNullOrEmpty(request.SubRegion)) {
            //     var filterBySubRegion = new CountryBySubRegion(request.SubRegion);

            //     var countryFiltered = response.Where(c => filterBySubRegion.IsSatisfiedBy(c));

            //     GetFilterList(countryList, countryFiltered);
            // }
            else
            {
                response.ForEach(
                    country =>
                        countryList.Add(
                            new GetCountries
                            {
                                Name = country.name.common ?? string.Empty,
                                Abbreviation = country.cca3 ?? string.Empty,
                                Capital =
                                country.capital != null ? country.capital[0] : string.Empty,
                                Area = country.area,
                                Population = country.population,
                                Region = country.region ?? string.Empty,
                                SubRegion = country.subregion ?? string.Empty
                            }
                        )
                );
            }

            return await Task.FromResult(countryList);
        }

        private static void GetFilterList(List<GetCountries> countryList, IEnumerable<Country> countryFiltered)
        {
            foreach (var country in countryFiltered)
            {
                countryList.Add(
                    new GetCountries
                    {
                        Name = country.name.common ?? string.Empty,
                        Abbreviation = country.cca3 ?? string.Empty,
                        Capital = country.capital != null ? country.capital[0] : string.Empty,
                        Area = country.area,
                        Population = country.population,
                        Region = country.region ?? string.Empty,
                        SubRegion = country.subregion ?? string.Empty
                    }
                );
            }
        }
    }
}
