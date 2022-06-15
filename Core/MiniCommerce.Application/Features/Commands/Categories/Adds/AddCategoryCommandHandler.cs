//using AutoMapper;
//using MediatR;
//using MiniCommerce.Application.Models;
//using MiniCommerce.Application.Services.CategoryService;
//using MiniCommerce.Domain.Entities;
//using MiniCommerce.Domain.Enum;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MiniCommerce.Application.Features.Commands.Categories.Adds
//{
//    public class AddCategoryCommandHandler :IRequestHandler<AddCategoryCommand, ResponseViewModelBase<NoContent>>

//    {
//        private readonly IMapper _mapper;
//        private readonly ICategoryService _categoryService;

//        public AddCategoryCommandHandler(ICategoryService categoryService,
//            IMapper mapper)
//        {
//            _categoryService = categoryService;
//            _mapper = mapper;
//        }
//        public async Task<ResponseViewModelBase<NoContent>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
//        {
//            var categoryEntity = _mapper.Map<Category>(request);

//            var newCategoryEntity = await _categoryService.AddAsync(categoryEntity);
//            await _categoryService.SaveAsync();

//            return ResponseViewModelBase<NoContent>.Success(ResultTypeEnum.Success);
//        }

//}
//}
