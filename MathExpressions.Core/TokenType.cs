using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public enum TokenType
    {
        Number,      
        Identifier, 
        Plus,       
        Minus,      
        Star,        
        Slash,      
        LParen,     
        RParen,      
        EndOfInput   
    }
}
