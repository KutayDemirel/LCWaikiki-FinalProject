using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.UsageService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Usages.GetUsages
{
    public class GetAllUsagesQueryHandler : IRequestHandler<GetAllUsagesQuery, ServiceResponse<IReadOnlyList<GetAllUsagesQueryResponse>>>
    {
        private readonly IUsageService _usageService;
        private readonly IMapper _mapper;

        public GetAllUsagesQueryHandler(IMapper mapper, IUsageService usageService)
        {
            _usageService = usageService;
            _mapper = mapper;
        }

        public virtual async Task<ServiceResponse<IReadOnlyList<GetAllUsagesQueryResponse>>> Handle(GetAllUsagesQuery request, CancellationToken cancellationToken)
        {
            var usageList = _usageService.GetAll(false);
            IReadOnlyList<GetAllUsagesQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllUsagesQueryResponse>>(usageList);
            return new ServiceResponse<IReadOnlyList<GetAllUsagesQueryResponse>>(ResultTypeEnum.Success, "Usages getirildi", vm);

        }
    }
}
