using System;


namespace MiniCommerce.Application.Exceptions
{
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions()
            : base()
        { }

        public NotFoundExceptions(string message)
            : base(message)
        { }

        public NotFoundExceptions(string message, Exception innerException)
            : base(message, innerException)
        { }

        public NotFoundExceptions(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        { }
    }
}
