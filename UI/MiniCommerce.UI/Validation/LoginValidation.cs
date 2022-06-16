using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class LoginValidation : AbstractValidator<SignInModel>
    {
        public LoginValidation()
        {
            RuleFor(p => p.Email).MaximumLength(40).WithMessage("Email alanı en fazla 40 karakter olmalıdır.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email alanı doğru girilmedi");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Sifre alanını doldurmanız gerekiyor");
            RuleFor(p => p.Password).NotNull().WithMessage("Hatalı şifre girdiniz");
        }

    }
}
