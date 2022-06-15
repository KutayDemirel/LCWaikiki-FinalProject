using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Queries.Brands.GetBrands;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(response);
        }




    }
}
