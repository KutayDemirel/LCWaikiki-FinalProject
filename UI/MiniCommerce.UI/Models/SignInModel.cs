using System.ComponentModel.DataAnnotations;

namespace MiniCommerce.UI.Models
{
    public class SignInModel
    {
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
  
    }

}
