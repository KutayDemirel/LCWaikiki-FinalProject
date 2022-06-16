using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Features.Queries.Categories.GetAllCategories;
using System.Threading.Tasks;

namespace MiniCommerce.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase

    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(response);

        }
        ////[Authorize]
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CategoryDetailViewModel>> GetById(int id)
        //{
        //    var category = await _categoryService.GetByIdAsync(id);

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    CategoryDetailViewModel result = _mapper.Map<CategoryDetailViewModel>(category);
        //    return result;
        //}
        //[HttpPut]
        //public async Task<IActionResult> Update(UpdateCategoryViewModel updatedCategory)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var category = await _categoryService.GetByIdAsync(updatedCategory.Id);

        //        if (category == null)
        //        {
        //            return NotFound();
        //        }
        //        _mapper.Map(updatedCategory, category);
        //        _categoryService.Update(category);
        //        await _categoryService.SaveAsync();

        //        return Ok();
        //    }
        //    return BadRequest();
        //}
        //[HttpPost]
        //[ActionName(nameof(AddAsync))]
        //public async Task<IActionResult> AddAsync(CreateCategoryViewModel request)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var category = _mapper.Map<Category>(request);
        //        await _categoryService.AddAsync(category);
        //        await _categoryService.SaveAsync();
        //        return CreatedAtAction("AddAsync", category); // view model döndürmez
        //    }
        //    return BadRequest();
        //}
        ////[Authorize]
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> RemoveAsync(string id)
        //{

        //    await _categoryService.RemoveAsync(id);
        //    await _categoryService.SaveAsync();
        //    return Ok();
        //}

    }
}