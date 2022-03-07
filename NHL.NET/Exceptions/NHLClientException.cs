using System;

namespace NHL.NET.Exceptions
{
    public class NHLClientException : Exception
    {
        public NHLClientException()
        {
        }

        public NHLClientException(string message)
            : base(message)
        {
        }
    }
}
