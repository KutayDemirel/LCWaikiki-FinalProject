using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Offers.Adds
{
    public class AddOfferCommandValidator : AbstractValidator<AddOfferCommand>
    {
        public AddOfferCommandValidator()
        {
            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("Price is required.")
                .GreaterThan(0).WithMessage("Price must be higher than 0.");
        }

    }
}
