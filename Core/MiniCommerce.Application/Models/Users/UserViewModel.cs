using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Models.Users
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<string> Roles { get; set; }
        public string Token { get; set; }
        //public DateTime LastLoginDate { get; set; }
    }
}
