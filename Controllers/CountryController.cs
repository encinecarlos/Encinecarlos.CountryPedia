using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encinecarlos.CountryPedia.Application.Dtos;
using Encinecarlos.CountryPedia.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Encinecarlos.CountryPedia.Controllers
{
    [ApiController]
    [Route("v1/countries")]
    public class CountryController : ControllerBase
    {
        private IMediator _mediator {get; init; }

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetCountries([FromQuery] GetCountriesQuery filter, CancellationToken cancellationToken)
        {
            var result = _mediator.Send(filter, cancellationToken);

            return await result;
        }
    }
}