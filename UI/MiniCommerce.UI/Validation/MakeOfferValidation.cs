using FluentValidation;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.ViewModels;

namespace MiniCommerce.UI.Validation
{
    public class MakeOfferValidation : AbstractValidator<ProductOfferViewModel>
    {
        public MakeOfferValidation()
        {
            RuleFor(x => x.Offer.Price).GreaterThan(0)
               .WithMessage("Offer must be higher than 0");
        }
    }
}
