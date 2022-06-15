using System.ComponentModel.DataAnnotations;

namespace MiniCommerce.UI.Models
{
    public class SignUpModel
    {
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        



    }
}
