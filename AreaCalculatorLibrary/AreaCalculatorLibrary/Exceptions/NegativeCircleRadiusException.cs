using System;

namespace AreaCalculatorLibrary.Exceptions
{
    public class NegativeCircleRadiusException : Exception
    {
        public NegativeCircleRadiusException() 
            : base("Radius must be a positive number")
        {

        }
    }
}
