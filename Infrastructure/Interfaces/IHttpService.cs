using Encinecarlos.CountryPedia.Domain.Entities;

namespace Encinecarlos.CountryPedia.Infrastructure.Interfaces
{
    public interface IHttpService
    {
        public Task<List<Country>> GetAllCountries();
    }
}