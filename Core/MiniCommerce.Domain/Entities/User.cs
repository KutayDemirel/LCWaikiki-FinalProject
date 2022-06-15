using Microsoft.AspNetCore.Identity;
using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public User()
        {

            Offers = new HashSet<Offer>();

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        //public bool IsAdmin { get; set; }
        //public string VerifyCode { get; set; }
        //public DateTime VerifyDate { get; set; }
        //public bool Verified { get; set; }
        //public DateTime LastLoginDate { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
