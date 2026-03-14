using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public interface IExpressionParser
    {
        ExpressionNode Parse(string expressionText);
    }
}
