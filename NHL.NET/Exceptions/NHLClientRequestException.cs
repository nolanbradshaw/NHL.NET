using System;
using System.Collections.Generic;
using System.Text;

namespace NHL.NET.Exceptions
{
    public class NHLClientRequestException : Exception
    {
        public int StatusCode { get; }
        public NHLClientRequestException()
        {
        }

        public NHLClientRequestException(string message, int statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
