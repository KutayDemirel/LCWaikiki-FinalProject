using System;

namespace MiniCommerce.Application.Exceptions
{

    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException() : base() { }
    }
}
