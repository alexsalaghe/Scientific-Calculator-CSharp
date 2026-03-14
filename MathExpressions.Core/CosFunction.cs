using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class CosFunction : IMathFunction
    {
        public string Name
        {
            get { return "cos"; }
        }

        public double Evaluate(double x)
        {
            return Math.Cos(x);
        }
    }
}
