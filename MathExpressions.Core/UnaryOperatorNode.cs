using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
   
   
    
    public class UnaryOperatorNode : ExpressionNode
    {
        private readonly ExpressionNode _operand;
        private readonly UnaryOperatorType _operatorType;

        public UnaryOperatorNode(ExpressionNode operand, UnaryOperatorType operatorType)
        {
            _operand = operand ?? throw new ArgumentNullException(nameof(operand));
            _operatorType = operatorType;
        }

        public override double Evaluate()
        {
            double value = _operand.Evaluate();

            switch (_operatorType)
            {
                case UnaryOperatorType.Plus:
                    return value;

                case UnaryOperatorType.Minus:
                    return -value;

                default:
                    throw new InvalidOperationException("Operator unar necunoscut.");
            }
        }

        public override string ToInfix()
        {
            string symbol;

            switch (_operatorType)
            {
                case UnaryOperatorType.Plus:
                    symbol = "+";
                    break;

                case UnaryOperatorType.Minus:
                    symbol = "-";
                    break;

                default:
                    symbol = "?";
                    break;
            }

            return $"({symbol}{_operand.ToInfix()})";
        }
    }
}
