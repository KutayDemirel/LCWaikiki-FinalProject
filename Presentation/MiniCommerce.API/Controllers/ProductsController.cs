using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Repositories.CategoryRepo;
using MiniCommerce.Application.Repositories.ProductRepo;
using MiniCommerce.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _categoryWriteRepository = categoryWriteRepository;
            _categoryReadRepository = categoryReadRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {


            //await _categoryWriteRepository.AddAsync(new() { Name= "Kutay"});
            //await _categoryWriteRepository.AddAsync(new() { Name= "deay"});
            await _categoryWriteRepository.SaveAsync();
            var result = _categoryReadRepository.GetAll();
            return Ok(result);
            
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Category t)
        {
            await _categoryWriteRepository.AddAsync(t);
            await _categoryWriteRepository.SaveAsync();
            return Ok();
        }




    }
}
