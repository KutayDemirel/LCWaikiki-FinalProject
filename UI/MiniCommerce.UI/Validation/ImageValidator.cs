using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace MiniCommerce.UI.Validation
{
    public class ImageValidator : AbstractValidator<IFormFile>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Length).LessThanOrEqualTo(400000)
                .WithMessage("File size is larger than allowed");

            RuleFor(x => x.FileName).NotNull().Must(x => x.Contains("jpeg") || x.Contains("jpg") || x.Equals("image/png"))
                .WithMessage("File type is larger than allowed");

        }
    }
}