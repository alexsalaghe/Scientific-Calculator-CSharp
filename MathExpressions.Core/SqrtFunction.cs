using System;

namespace MathExpressions.Core
{
    public class SqrtFunction : IMathFunction
    {
        public string Name
        {
            get { return "sqrt"; }
        }

        public double Evaluate(double x)
        {
            if (x < 0)
                throw new ArgumentException("Square root argument must be non-negative.");

            return Math.Sqrt(x);
        }
    }
}
