using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class SinFunction : IMathFunction
    {
        public string Name
        {
            get { return "sin"; }
        }

        public double Evaluate(double x)
        {
            return Math.Sin(x);
        }
    }
}
