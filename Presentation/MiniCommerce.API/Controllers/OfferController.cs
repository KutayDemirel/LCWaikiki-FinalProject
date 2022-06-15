//using AutoMapper;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using MiniCommerce.Application.Models.Offers;
//using MiniCommerce.Application.Services.OfferService;
//using MiniCommerce.Domain.Entities;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace MiniCommerce.API.Controllers
//{
//    [Route("api/v1/[controller]")]
//    [ApiController]
//    public class OfferController : ControllerBase

//    {
//        private readonly IOfferService _offerService;
//        private readonly IMapper _mapper;

//        public OfferController(IOfferService offerService, IMapper mapper)
//        {
//            _offerService = offerService;
//            _mapper = mapper;
//        }
//        [Authorize]
//        [HttpGet]
//        public ActionResult<IEnumerable<OffersViewModel>> GetAll()
//        {
//            var offerList = _offerService.GetAll(false);
//            List<OffersViewModel> vm = _mapper.Map<List<OffersViewModel>>(offerList);
//            return vm;

//        }
//        [Authorize]
//        [HttpGet("{id}")]
//        public async Task<ActionResult<OfferDetailViewModel>> GetById(int id)
//        {
//            var offer = await _offerService.GetByIdAsync(id);

//            if (offer == null)
//            {
//                return NotFound();
//            }

//            OfferDetailViewModel result = _mapper.Map<OfferDetailViewModel>(offer);
//            return result;
//        }
//        [Authorize]
//        [HttpPut]
//        public async Task<IActionResult> Update(UpdateOfferViewModel updatedOffer)
//        {

//            if (ModelState.IsValid)
//            {
//                var offer = await _offerService.GetByIdAsync(updatedOffer.Id);

//                if (offer == null)
//                {
//                    return NotFound();
//                }
//                _mapper.Map(updatedOffer, offer);
//                _offerService.Update(offer);
//                await _offerService.SaveAsync();

//                return Ok();
//            }
//            return BadRequest();
//        }
//        [Authorize]
//        [HttpPost]
//        [ActionName(nameof(AddAsync))]
//        public async Task<IActionResult> AddAsync(CreateOfferViewModel request)
//        {
//            if (ModelState.IsValid)
//            {
//                var offer = _mapper.Map<Offer>(request);
//                await _offerService.AddAsync(offer);
//                await _offerService.SaveAsync();
//                return CreatedAtAction("AddAsync", offer); // view model döndürmez
//            }
//            return BadRequest();
//        }
//        [Authorize]
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> RemoveAsync(string id)
//        {
//            await _offerService.RemoveAsync(id);
//            await _offerService.SaveAsync();
//            return Ok();
//        }

//    }
//}