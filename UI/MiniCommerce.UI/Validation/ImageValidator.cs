using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace MiniCommerce.UI.Validation
{
    public class ImageValidator : AbstractValidator<IFormFile>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Length).LessThanOrEqualTo(400000)
                .WithMessage("Dosya 400kb'dan fazla");

            RuleFor(x => x.FileName).NotNull().Must(x => x.Contains("jpeg") || x.Contains("jpg") || x.Equals("image/png"))
                .WithMessage("Dosya türü hatalı");

        }
    }
}