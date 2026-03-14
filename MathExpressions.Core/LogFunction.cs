using System;

namespace MathExpressions.Core
{
    public class LogFunction : IMathFunction
    {
        public string Name
        {
            get { return "log"; }
        }

        public double Evaluate(double x)
        {
            if (x <= 0)
                throw new ArgumentException("Logarithm argument must be positive.");

            return Math.Log(x);
        }
    }
}
