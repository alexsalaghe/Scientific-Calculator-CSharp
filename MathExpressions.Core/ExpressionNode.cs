using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    
  
    
    public abstract class ExpressionNode
    {
        public abstract double Evaluate();
        public abstract string ToInfix();
    }
}
