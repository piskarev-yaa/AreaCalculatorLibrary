using System;

namespace AreaCalculatorLibrary.Exceptions
{
    public class NegativeTriangleSideException : Exception
    {
        public NegativeTriangleSideException()
            : base ("Side must be a positive number")
        {

        }
    }
}
