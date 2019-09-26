using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    class StudentInvalidException : Exception
    {
        public StudentInvalidException(string field, Exception ex ) 
            : base($"AD Account \"{field}\" is invalid.", ex)
        {

        }
    }
}
