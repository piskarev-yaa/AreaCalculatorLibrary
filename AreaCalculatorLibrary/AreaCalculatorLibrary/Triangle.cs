using AreaCalculatorLibrary.Exceptions;
using System;

namespace AreaCalculatorLibrary
{
    public class Triangle : AShape
    {
        private double rightAccuracy = 1e-6;
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public double FirstSide
        {
            get
            {
                return firstSide;
            }
            private set
            {
                if (value > 0)
                    firstSide = value;
                else
                    throw new NegativeTriangleSideException();
            }
        }

        public double SecondSide
        {
            get
            {
                return secondSide;
            }
            private set
            {
                if (value > 0)
                    secondSide = value;
                else
                    throw new NegativeTriangleSideException();
            }
        }

        public double ThirdSide
        {
            get
            {
                return thirdSide;
            }
            private set
            {
                if (value > 0)
                    thirdSide = value;
                else
                    throw new NegativeTriangleSideException();
            }
        }

        public bool IsTriangleRight 
        { 
            get
            {
                double largestSide = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
                return Math.Abs(largestSide * largestSide - (firstSide * firstSide + secondSide * secondSide)) < rightAccuracy;
            } 
        }


        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            if (!IsTriangleConditionCompleted())
                throw new TriangleConditionException();
        }


        public override double CalculateArea()
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        private bool IsTriangleConditionCompleted()
        {
            return firstSide < secondSide + thirdSide && 
                   secondSide < firstSide + thirdSide && 
                   thirdSide < firstSide + secondSide;
        }
    }
}
