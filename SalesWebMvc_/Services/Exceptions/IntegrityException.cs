using System;

namespace SalesWebMvc_.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException (string message) : base(message)
        {

        }
    }
}
