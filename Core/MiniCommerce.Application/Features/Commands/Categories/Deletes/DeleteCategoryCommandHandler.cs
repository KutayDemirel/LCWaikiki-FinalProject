//using AutoMapper;
//using MediatR;
//using MiniCommerce.Application.Models;
//using MiniCommerce.Application.Services.CategoryService;
//using MiniCommerce.Domain.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MiniCommerce.Application.Features.Commands.Categories.Deletes
//{
//    public class DeleteCategoryCommandHandler
//    {
//        private readonly IMapper _mapper;
//        private readonly ICategoryService _categoryService;

//        public DeleteCategoryCommandHandler(ICategoryService categoryService,
//            IMapper mapper)
//        {
//            _categoryService = categoryService;
//            _mapper = mapper;
//        }
//        public async Task<ResponseBase> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
//        {
//            var categoryEntity = _mapper.Map<Category>(request);

//            var newCategoryEntity = await _categoryService.RemoveAsync(categoryEntity);

//            return null;
//        }
//    }
//}
