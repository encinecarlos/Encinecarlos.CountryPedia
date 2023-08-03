using Encinecarlos.CountryPedia.Domain.Entities;

namespace Encinecarlos.CountryPedia.Application.specification
{
    public class CountryBySubRegion : ISpecification<Country>
    {
        private readonly string subRegion;

        public CountryBySubRegion(string subRegion)
        {
            this.subRegion = subRegion;
        }

        public bool IsSatisfiedBy(Country item)
        {
            return item.subregion == subRegion; 
        }
    }
}