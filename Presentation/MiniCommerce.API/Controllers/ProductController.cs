using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Commands.Products.Adds;
using MiniCommerce.Application.Features.Commands.Products.Updates.BuyProduct;
using MiniCommerce.Application.Features.Queries.Products.GetProductById;
using MiniCommerce.Application.Features.Queries.Products.GetProductList;
using MiniCommerce.Application.Features.Queries.Products.GetProductsByCategoryId;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Models.Products;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IProductService _productService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public ProductController(IMediator mediator, IProductService productService, IMapper mapper, UserManager<User> userManager)
        {
            _mediator = mediator;
            _productService = productService;
            _mapper = mapper;
            _userManager = userManager;
        }
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllProductsQuery());
            return Ok(response);
        }

        #region  NonMediatr get all

        //[HttpGet]
        //public ActionResult<IEnumerable<ProductsViewModel>> GetAll()
        //{
        //    var productList = _productService.GetAll(false);
        //    List<ProductsViewModel> vm = _mapper.Map<List<ProductsViewModel>>(productList);
        //    return vm;
        //}
        #endregion

        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetProductByIdQueryResponse>>> GetById(int id)
        {

            var response = await _mediator.Send(new GetProductByIdQuery() { Id = id });
            return Ok(response);

            //var product = await _productService.GetByIdAsync(id, false);

            //if (product == null)
            //{
            //    return NotFound();
            //}

            //ProductDetailViewModel result = _mapper.Map<ProductDetailViewModel>(product);
            //var response = new ServiceResponse<ProductDetailViewModel>(ResultTypeEnum.Success, "", result);
        }

        [HttpGet("Search")]
        public async Task<ActionResult<ServiceResponse<GetProductsByCategoryIdQueryResponse>>> GetProductsByCategoryId([FromQuery] int categoryId)
        {


            var response = await _mediator.Send(new GetProductsByCategoryIdQuery() { Id = categoryId });
            return Ok(response);

            //var product = _productService.GetWhere(products => products.CategoryId == categoryId, false);

            //if (product == null)
            //{
            //    return NotFound();
            //}

            //List<ProductsViewModel> result = _mapper.Map<List<ProductsViewModel>>(product);
            //var response = new ServiceResponse<List<ProductsViewModel>>(ResultTypeEnum.Success, "", result);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddProductCommand request)
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
        public async Task<IActionResult> Update(BuyProductCommand buyProductModel)
        {


            var result = await _mediator.Send(buyProductModel);
            return Ok(result);


            //if (ModelState.IsValid)
            //{
            //    var product = await _productService.GetByIdAsync(buyProductModel.Id);

            //    if (product == null)
            //    {
            //        return NotFound();
            //    }
            //    _mapper.Map(buyProductModel, product);
            //    _productService.Update(product);
            //    await _productService.SaveAsync();

            //    return Ok();
            //}
            //return BadRequest();
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAsync(string id)
        {
            await _productService.RemoveAsync(id);
            await _productService.SaveAsync();
            return Ok();
        }



        #region Add Without Mediatr
        //[HttpPost]
        //[ActionName(nameof(AddAsync))]
        //public async Task<ActionResult> AddAsync([FromBody] AddProductCommand productDto)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var product = _mapper.Map<Product>(productDto);
        //        await _productService.AddAsync(product);
        //        await _productService.SaveAsync();
        //        return CreatedAtAction("AddAsync", product);
        //    }
        //    return BadRequest();
        //}
        #endregion


        #region Add Mediatr 1
        //[HttpPost]
        //public async Task<IActionResult> Add(AddProductCommand request)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ProductViewModel response = await _mediator.Send(request);
        //        return StatusCode((int)HttpStatusCode.Created);
        //    }
        //    return BadRequest();
        //}
        #endregion


        #region NoContent

        //[NonAction]
        //public IActionResult CreateActionResult<T>(ResponseViewModelBase<T> response)
        //{

        //    return new ObjectResult(response) { StatusCode = 200 };
        //}

        #endregion
    }
}