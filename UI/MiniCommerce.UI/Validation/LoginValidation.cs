using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class LoginValidation : AbstractValidator<SignInModel>
    {
        public LoginValidation()
        {
            RuleFor(p => p.Email).MaximumLength(40).WithMessage("Email alani en fazla 40 karakter olmalidir.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alani boş olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email alani doğru girilmedi");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Sifre alanini doldurmaniz gerekiyor");
        }

    }
}
