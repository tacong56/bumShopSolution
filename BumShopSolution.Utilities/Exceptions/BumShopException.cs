using System;
using System.Collections.Generic;
using System.Text;

namespace BumShopSolution.Utilities.Exceptions
{
    public class BumShopException : Exception
    {
        public BumShopException()
        {
        }

        public BumShopException(string message) : base(message)
        {
        }

        public BumShopException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
