
using Restaurant.Pizza.Application.Features.Sizes.Queries.GetAllSize;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restaurant.Pizza.Application.Features.Todos.Queries.GetAllTodos;

namespace Restaurant.Pizza.WebApi.Controllers
{
    [Route("ns-ms-name/api/[controller]")]
    [ApiController]
    public class Sizes : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SizeDto>))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllSizesQuery() { }));
        }

    }
}