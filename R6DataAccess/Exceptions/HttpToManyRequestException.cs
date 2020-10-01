using System;
using System.Collections.Generic;
using System.Text;

namespace R6DataAccess
{
    class HttpToManyRequestException : Exception
    {
        public HttpToManyRequestException()
        {
        }
        public HttpToManyRequestException(string message) : base(message)
        {
        }
    }
}
