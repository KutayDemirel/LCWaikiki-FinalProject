using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.ColorService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Colors.GetColors
{
    public class GetAllColorsQueryHandler : IRequestHandler<GetAllColorsQuery, ServiceResponse<IReadOnlyList<GetAllColorsQueryResponse>>>
    {
        private readonly IColorService _colorService;
        private readonly IMapper _mapper;

        public GetAllColorsQueryHandler(IMapper mapper, IColorService colorService)
        {
            _colorService = colorService;
            _mapper = mapper;
        }

        public virtual async Task<ServiceResponse<IReadOnlyList<GetAllColorsQueryResponse>>> Handle(GetAllColorsQuery request, CancellationToken cancellationToken)
        {
            var colorList = _colorService.GetAll(false);
            IReadOnlyList<GetAllColorsQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllColorsQueryResponse>>(colorList);
            return new ServiceResponse<IReadOnlyList<GetAllColorsQueryResponse>>(ResultTypeEnum.Success, "Colors getirildi", vm);

        }
    }
}
