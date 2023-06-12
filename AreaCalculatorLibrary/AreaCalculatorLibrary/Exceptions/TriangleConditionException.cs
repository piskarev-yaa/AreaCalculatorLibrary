using System;

namespace AreaCalculatorLibrary.Exceptions
{
    public class TriangleConditionException : Exception
    {
        public TriangleConditionException()
            : base ("Tringle is degenerate. Triangle condition isn't completed")
        {

        }
    }
}
