using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Queries.Usages.GetUsages;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllUsagesQuery());
            return Ok(response);
        }
    }
}
