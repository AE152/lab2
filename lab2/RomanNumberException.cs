using System;

namespace lab2
{
    class RomanNumberException : Exception
    {
        public RomanNumberException (string message)
            : base(message)
        {}
    }
}
