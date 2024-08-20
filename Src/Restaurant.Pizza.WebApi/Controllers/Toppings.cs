

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Pizza.Application.Features.Toppings.Queries;
using Restaurant.Pizza.Application.Features.Toppings.Queries.GetAllToppings;

namespace Restaurant.Pizza.WebApi.Controllers
{
    [ApiController]
    [Route("ns-ms-name/api/[controller]")]
    public class Toppings : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ToppingDto>))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllToppingsQuery() { }));
        }
    }
}