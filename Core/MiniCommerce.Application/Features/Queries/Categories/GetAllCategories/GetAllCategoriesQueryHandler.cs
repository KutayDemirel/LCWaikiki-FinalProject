using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.CategoryService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, ServiceResponse<IReadOnlyList<GetAllCategoriesQueryResponse>>>
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryHandler(IMapper mapper, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IReadOnlyList<GetAllCategoriesQueryResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categoryList = _categoryService.GetAll(false);

            IReadOnlyList<GetAllCategoriesQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllCategoriesQueryResponse>>(categoryList);
            return new ServiceResponse<IReadOnlyList<GetAllCategoriesQueryResponse>>(ResultTypeEnum.Success, "Category Eklendi", vm);
        }
    }
}
