using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    class LoanInvalidException : Exception
    {
        public LoanInvalidException(string field, Exception ex)
            : base($"AD Account \"{field}\" is invalid.", ex)
        {

        }
    }
}
