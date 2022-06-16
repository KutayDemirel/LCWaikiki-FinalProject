using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class SignUpValidation :AbstractValidator<SignUpModel>
    {
        public SignUpValidation()
        {

            RuleFor(p => p.Email).MaximumLength(40).WithMessage("Email alanı en fazla 40 karakter olmalıdır.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alani boş olamaz");
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(p => p.FirstName).MinimumLength(2).WithMessage("İsim yanlış girildi");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(p => p.LastName).MinimumLength(1).WithMessage("Soyad yanlış girildi");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres alanı boş olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email alanı doğru girilmedi");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Sifre alanını doldurmaniz gerekiyor");
            RuleFor(p => p.Password).MinimumLength(8).WithMessage("Şifren en az 8 karakter içermelidir.")
                    .MaximumLength(16).WithMessage("Şifren en fazla 16 karakter içermelidir.")
                    .Matches(@"[A-Z]+").WithMessage("Şifrende en az bir büyük harf olmalıdır.")
                    //.Matches(@"[a-z]+").WithMessage("Şifrende en az bir küçük harf olmalıdır.")
                    .Matches(@"[0-9]+").WithMessage("Şifrende en az bir sayı olmalıdır.")
                    .Matches(@"[\!\?\*\.]+").WithMessage("Şifrende en az bir özel karakter olmalıdır.");
        }
    }
}
