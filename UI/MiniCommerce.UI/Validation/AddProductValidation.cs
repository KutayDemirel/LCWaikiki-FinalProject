using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class AddProductValidation : AbstractValidator<AddProductModel>
    {
        public AddProductValidation()
        {
            RuleFor(p => p.Price).NotNull().WithMessage("Fiyat girmelisin.")
                .NotEmpty().WithMessage("Fiyat girmelisin.")
                .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır.");


            RuleFor(p => p.Image).NotNull().WithMessage("Resim Eklemelisin.").NotEmpty().WithMessage("Resim Eklemelisin.");
            //RuleFor(p => p.Image).NotEmpty().WithMessage("Image must be uploaded.").SetValidator(new FileValidator());


            //RuleFor(x => x.Image.Length).LessThanOrEqualTo(400000).WithMessage("Güven enes 2");
            //RuleFor(x => x.Image.ContentType).Must(x => x.Contains("jpeg") || x.Contains("jpg") || x.Contains("png"))
            //    .WithMessage("Güven enes 1");




            RuleFor(x => x.Image).SetValidator(new ImageValidator());



            RuleFor(p => p.Stock).NotNull().NotEmpty().WithMessage("Stok bilgisi girmelisin.")
                .GreaterThan(0).WithMessage("Stok bilgisi 0'dan fazla olmalıdır.");
            RuleFor(p => p.UsageId).NotEmpty().WithMessage("Kullanım durumu seçilmelidir.")
                .NotNull().WithMessage("Kullanım durumu seçilmelidir.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori bilgisi seçilmelidir.")
                .NotNull().WithMessage("Kategori bilgisi seçilmelidir.");
            RuleFor(p => p.Name).NotNull().WithMessage("İsim girmelisin.")
                .NotEmpty().WithMessage("İsim girmelisin.")
                .MaximumLength(100).WithMessage("100 karakterden fazla isim giremezsin");
            RuleFor(p => p.Description).NotNull().WithMessage("Açıklama girmelisin")
                .NotEmpty().WithMessage("Açıklama girmelisin")
                .MaximumLength(300).WithMessage("300 karakterden fazla açıklama giremezsin.");
        }

    }
}
