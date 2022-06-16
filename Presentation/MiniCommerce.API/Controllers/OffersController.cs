using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Commands.Offers.Adds;
using MiniCommerce.Application.Features.Commands.Offers.Deletes;
using MiniCommerce.Application.Features.Commands.Offers.Updates.ApproveOffer;
using MiniCommerce.Application.Features.Queries.Offers.GetAllReceivedOffers;
using MiniCommerce.Application.Features.Queries.Offers.GetAllSubmittedOffers;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Domain.Entities;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserManager<User> _userManager;

        public OffersController(IMediator mediator, UserManager<User> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllReceived()
        {

            var userId = _userManager.Users.FirstOrDefault(x => x.Email == HttpContext.User.Identity.Name).Id;
            var response = await _mediator.Send(new GetAllReceivedOffersQuery() { UserId = userId });
            return Ok(response);
        }

        [Authorize]
        [HttpGet("Submit")]
        public async Task<IActionResult> GetAllSubmitted()
        {

            var userId = _userManager.Users.FirstOrDefault(x => x.Email == HttpContext.User.Identity.Name).Id;
            var response = await _mediator.Send(new GetAllSubmittedOffersQuery() { UserId = userId });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddOfferCommand request)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.Users.FirstOrDefault(x => x.Email == HttpContext.User.Identity.Name).Id;
                request.UserId = userId;

                var response = await _mediator.Send(request);
                return Ok(response);
            }
            return BadRequest();
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(ApproveOfferCommand approveOfferCommand)
        {


            var result = await _mediator.Send(approveOfferCommand);
            return Ok(result);


        }
        //[HttpDelete]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult<int>> Delete(int id) ===> **Query String**
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteOffer(int id)
        {
            var result = await _mediator.Send(new DeleteOfferCommand { Id = id });
            return Ok(result);
        }



    }
}
