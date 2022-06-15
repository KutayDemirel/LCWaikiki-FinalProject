using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Domain.Entities
{
    public class Offer : BaseEntity
    {
        public decimal Price { get; set; }
        public bool IsApproved { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
