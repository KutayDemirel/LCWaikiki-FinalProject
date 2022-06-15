using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Models.Users;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Authentications.GetUser
{
    public class GetUserByEmailAndPasswordQueryHandler : IRequestHandler<GetUserByEmailAndPasswordQuery, ServiceResponse<UserViewModel>>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;

        public GetUserByEmailAndPasswordQueryHandler(UserManager<User> userManager,
                 RoleManager<Role> roleManager,
                 IMapper mapper
                 )
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task<ServiceResponse<UserViewModel>> Handle(GetUserByEmailAndPasswordQuery request, CancellationToken cancellationToken)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);
            if (user is null)
            {
                return null;
            }

            var userModel = _mapper.Map<UserViewModel>(user);

            var userSigninResult = await _userManager.CheckPasswordAsync(user, request.Password);

            if (userSigninResult)
            {
                userModel.Roles = await _userManager.GetRolesAsync(user);
            }
            var response = new ServiceResponse<UserViewModel>(ResultTypeEnum.Success, "", userModel);

            return response;
        }
    }
}
