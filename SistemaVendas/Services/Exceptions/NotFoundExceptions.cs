using System;

namespace SistemaVendas.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base (message)
        {

        }
    }
}
