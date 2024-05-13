﻿using System.Globalization;

namespace Ecommerce.Core.Exception
{
    public class ApiException : System.Exception
    {
        public ApiException() : base() { }

        public ApiException(string message) : base(message) { }

        public ApiException(string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
