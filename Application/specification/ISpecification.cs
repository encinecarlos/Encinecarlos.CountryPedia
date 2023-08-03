using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encinecarlos.CountryPedia.Application.specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }
}