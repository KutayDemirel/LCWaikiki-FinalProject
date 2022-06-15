using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class AddProductValidation : AbstractValidator<AddProductModel>
    {
        public AddProductValidation()
        {
            RuleFor(p => p.Price).NotNull().WithMessage("You must enter a price.")
                .NotEmpty().WithMessage("You must enter a price.")
                .GreaterThan(0).WithMessage("Price must be higher than 0.");


            RuleFor(p => p.Image).NotNull().WithMessage("Image must be asdasd.").NotEmpty().WithMessage("Image must be katık.");
            //RuleFor(p => p.Image).NotEmpty().WithMessage("Image must be uploaded.").SetValidator(new FileValidator());


            //RuleFor(x => x.Image.Length).LessThanOrEqualTo(400000).WithMessage("Güven enes 2");
            //RuleFor(x => x.Image.ContentType).Must(x => x.Contains("jpeg") || x.Contains("jpg") || x.Contains("png"))
            //    .WithMessage("Güven enes 1");




            RuleFor(x => x.Image).SetValidator(new ImageValidator());



            RuleFor(p => p.Stock).NotNull().NotEmpty().WithMessage("You must enter a stock status.")
                .GreaterThan(0).WithMessage("Stock status must be higher than 0");
            RuleFor(p => p.UsageId).NotEmpty().WithMessage("Usage Status must be selected.")
                .NotNull().WithMessage("Usage Status must be selected.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Name must be selected.")
                .NotNull().WithMessage("Category Name must be selected.");
            RuleFor(p => p.Name).NotNull().WithMessage("You must enter a name.")
                .NotEmpty().WithMessage("You must enter a name.")
                .MaximumLength(100).WithMessage("You can not type more than 100 character for name.");
            RuleFor(p => p.Description).NotNull().WithMessage("You must enter a description")
                .NotEmpty().WithMessage("You must enter a description")
                .MaximumLength(300).WithMessage("You can not type more than 300 character for description.");
        }

    }
}
