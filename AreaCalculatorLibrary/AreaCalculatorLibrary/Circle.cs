using AreaCalculatorLibrary.Exceptions;
using System;

namespace AreaCalculatorLibrary
{
    public class Circle : AShape
    {
        private double radius;

        public double Radius 
        { 
            get
            {
                return radius;
            }
            private set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new NegativeCircleRadiusException();
            } 
        }


        public Circle(double radius)
        {
            Radius = radius;
        }


        public override double CalculateArea()
        {
            return Math.PI * radius * radius;   
        }
    }
}
