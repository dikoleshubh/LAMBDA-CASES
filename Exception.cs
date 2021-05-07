using System;
using System.Collections.Generic;
using System.Text;

namespace ReX
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException()
        {
        }

        public InvalidDataException(string message) : base(message)
        {
        }

    }
}
