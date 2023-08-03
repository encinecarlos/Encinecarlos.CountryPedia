using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encinecarlos.CountryPedia.Application.Dtos
{
    public class GetCountries
    {
        public string? Name { get; set; }
        public string? Abbreviation { get; set; }
        public string? Capital { get; set; }
        public string? Region { get; set; }
        public string? SubRegion { get; set; }
        public float Area { get; set; }
        public int Population { get; set; }

    }
}