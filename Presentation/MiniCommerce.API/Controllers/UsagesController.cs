using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Queries.Usages.GetUsages;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllUsagesQuery());
            return Ok(response);
        }
    }
}
