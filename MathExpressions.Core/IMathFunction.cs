using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    
    
       
        
      
        public interface IMathFunction
        {
            string Name { get; }         
            double Evaluate(double x);   
        }
    
}
