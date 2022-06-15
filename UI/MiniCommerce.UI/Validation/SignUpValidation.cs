using FluentValidation;
using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.Validation
{
    public class SignUpValidation :AbstractValidator<SignUpModel>
    {
        public SignUpValidation()
        {

            RuleFor(p => p.Email).MaximumLength(40).WithMessage("Email alani en fazla 40 karakter olmalidir.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alani boş olamaz");
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(p => p.FirstName).MinimumLength(2).WithMessage("İsim yanlış girildi");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(p => p.LastName).MinimumLength(1).WithMessage("Soyad yanlış girildi");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres alanı boş olamaz");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email alani doğru girilmedi");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Sifre alanini doldurmaniz gerekiyor");
        }
    }
}
