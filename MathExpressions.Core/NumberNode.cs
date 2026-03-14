using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    
   
  
    public class NumberNode : ExpressionNode
    {
        private readonly double _value;

        public NumberNode(double value)
        {
            _value = value;
        }

        public override double Evaluate()
        {
            return _value;
        }

        public override string ToInfix()
        {
            return _value.ToString();
        }
    }
}
