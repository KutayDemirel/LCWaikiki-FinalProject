using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Products.Adds
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("{Name} is required.");

            RuleFor(p => p.Stock)
                .NotEmpty().GreaterThan(0).WithMessage("{Stock} is required.");
        }
    
    }
}
