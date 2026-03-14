using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
   
  
    
    public class FunctionNode : ExpressionNode
    {
        private readonly IMathFunction _function;
        private readonly ExpressionNode _argument;

        public FunctionNode(IMathFunction function, ExpressionNode argument)
        {
            _function = function ?? throw new ArgumentNullException(nameof(function));
            _argument = argument ?? throw new ArgumentNullException(nameof(argument));
        }

        public override double Evaluate()
        {
            double argValue = _argument.Evaluate();
            return _function.Evaluate(argValue);
        }

        public override string ToInfix()
        {
            return string.Format("{0}({1})", _function.Name, _argument.ToInfix());
        }
    }
}
