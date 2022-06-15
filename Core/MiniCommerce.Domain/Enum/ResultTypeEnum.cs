using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Domain.Enum
{
    public enum ResultTypeEnum
    {
        Success = 1,
        Information = 2,
        Warning = 3,
        Error = 4,
        AuthenticationError = 5
    }
}
