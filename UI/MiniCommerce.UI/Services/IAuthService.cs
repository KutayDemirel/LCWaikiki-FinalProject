using MiniCommerce.UI.Models;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services
{
    public interface IAuthService
    {
        Task<string> SignIn(SignInModel signInModel);
        Task<string> SignUp(SignUpModel signUpModel);
    }

}
