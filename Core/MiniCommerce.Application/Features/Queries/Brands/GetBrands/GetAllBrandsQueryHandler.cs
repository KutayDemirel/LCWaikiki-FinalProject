using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.BrandService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Brands.GetBrands
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, ServiceResponse<IReadOnlyList<GetAllBrandsQueryResponse>>>
    {
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IMapper mapper, IBrandService brandService)
        {
            _brandService = brandService;
            _mapper = mapper;
        }

        public virtual async Task<ServiceResponse<IReadOnlyList<GetAllBrandsQueryResponse>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandList = _brandService.GetAll(false);
            //List<BrandsViewModel> vm = _mapper.Map<List<BrandsViewModel>>(brandList);
            IReadOnlyList<GetAllBrandsQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllBrandsQueryResponse>>(brandList);
            return new ServiceResponse<IReadOnlyList<GetAllBrandsQueryResponse>>(ResultTypeEnum.Success, "Brands getirildi", vm);
            //return ResponseViewModelBase<IReadOnlyList<BrandsViewModel>>.Success(vm,ResultTypeEnum.Success);
        }
    }
}
