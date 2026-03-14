using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    

   
    public class BinaryOperatorNode : ExpressionNode
    {
        private readonly ExpressionNode _left;
        private readonly ExpressionNode _right;
        private readonly BinaryOperatorType _operatorType;

        public BinaryOperatorNode(ExpressionNode left, ExpressionNode right, BinaryOperatorType operatorType)
        {
            _left = left ?? throw new ArgumentNullException(nameof(left));
            _right = right ?? throw new ArgumentNullException(nameof(right));
            _operatorType = operatorType;
        }

        public override double Evaluate()
        {
            double L = _left.Evaluate();
            double R = _right.Evaluate();

            switch (_operatorType)
            {
                case BinaryOperatorType.Add:
                    return L + R;
                case BinaryOperatorType.Subtract:
                    return L - R;
                case BinaryOperatorType.Multiply:
                    return L * R;
                case BinaryOperatorType.Divide:
                    if (R == 0)
                    {
                        throw new DivideByZeroException("Împărțire la zero.");
                    }
                    return L / R;
                default:
                    throw new InvalidOperationException("Operator necunoscut.");
            }
        }

        public override string ToInfix()
        {
            string symbol;

            switch (_operatorType)
            {
                case BinaryOperatorType.Add:
                    symbol = "+";
                    break;

                case BinaryOperatorType.Subtract:
                    symbol = "-";
                    break;

                case BinaryOperatorType.Multiply:
                    symbol = "*";
                    break;

                case BinaryOperatorType.Divide:
                    symbol = "/";
                    break;

                default:
                    symbol = "?";
                    break;
            }

            return $"({_left.ToInfix()} {symbol} {_right.ToInfix()})";
        }
    }
}
