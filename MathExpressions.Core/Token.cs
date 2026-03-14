using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class Token
    {
        private readonly TokenType _type;
        private readonly string _text;

        public TokenType Type
        {
            get { return _type; }
        }

        public string Text
        {
            get { return _text; }
        }

        public Token(TokenType type, string text)
        {
            _type = type;
            _text = text;
        }

        public override string ToString()
        {
            return string.Format("{0} ('{1}')", _type, _text);
        }
    }
}
