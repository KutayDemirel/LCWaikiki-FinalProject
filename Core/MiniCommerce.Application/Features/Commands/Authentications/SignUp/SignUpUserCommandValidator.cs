using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Authentications.SignUp
{
    public class SignUpUserCommandValidator : AbstractValidator<SignUpUserCommand>
    {
        public SignUpUserCommandValidator()
        {

            RuleFor(p => p.Email).NotEmpty().WithMessage("{Email Address} is required.");

            RuleFor(p => p.Password).NotEmpty().WithMessage("{Password} is required.");

        }
    }
}
