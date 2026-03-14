using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
   
  
    
    public class FunctionRegistry
    {
        private readonly List<IMathFunction> _functions = new List<IMathFunction>();

        public FunctionRegistry()
        {
        }

        public void Register(IMathFunction function)
        {
            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            _functions.Add(function);
        }

        
        public IMathFunction FindByName(string name)
        {
            if (name == null)
            {
                return null;
            }

            foreach (var f in _functions)
            {
                if (string.Equals(f.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return f;
                }
            }

            return null;
        }
    }
}
