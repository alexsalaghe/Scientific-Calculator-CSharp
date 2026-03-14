using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    
    
   
    public class ExpressionEngine
    {
        private readonly FunctionRegistry _registry;
        private readonly IExpressionParser _parser;

        public ExpressionEngine()
        {
           
            _registry = new FunctionRegistry();
            _registry.Register(new SinFunction());
            _registry.Register(new CosFunction());
            _registry.Register(new LogFunction());
            _registry.Register(new SqrtFunction());
            

            
            _parser = new RecursiveDescentParser(_registry);
        }

      
       
       
        public double Evaluate(string expressionText)
        {
            if (expressionText == null)
            {
                throw new ArgumentNullException(nameof(expressionText));
            }

            ExpressionNode node = _parser.Parse(expressionText);
            return node.Evaluate();
        }
    }
}
