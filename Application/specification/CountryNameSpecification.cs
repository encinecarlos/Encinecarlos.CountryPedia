using Encinecarlos.CountryPedia.Domain.Entities;

namespace Encinecarlos.CountryPedia.Application.specification
{
    public class CountryNameSpecification : ISpecification<Country>
    {
        private readonly string Name;

        public CountryNameSpecification(string name)
        {
            Name = name;
        }

        public bool IsSatisfiedBy(Country item)
        {
            return item.name.common == Name;
        }
    }
}