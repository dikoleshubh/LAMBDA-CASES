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

        //public InvalidException(string message, Exception innerException) : base(message, innerException)
        //{
        //}

        //protected InvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}
