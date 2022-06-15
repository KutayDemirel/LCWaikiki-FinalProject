using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Authentications.GetUser
{
    public class GetUserByEmailAndPasswordQuery : IRequest<ServiceResponse<UserViewModel>>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public GetUserByEmailAndPasswordQuery(string email, string password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));

        }
    }
}
