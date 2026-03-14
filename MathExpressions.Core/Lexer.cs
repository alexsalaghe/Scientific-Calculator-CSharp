using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class Lexer
    {
        private string _input;
        private int _pos;

        public Lexer(string input)
        {
            Reset(input);
        }

        public void Reset(string input)
        {
            _input = input ?? string.Empty;
            _pos = 0;
        }

        private char CurrentChar
        {
            get
            {
                if (_pos >= _input.Length)
                {
                    return '\0';  
                }
                return _input[_pos];
            }
        }

        private void Advance()
        {
            _pos++;
        }

        private void SkipWhitespace()
        {
            while (char.IsWhiteSpace(CurrentChar))
            {
                Advance();
            }
        }

        public Token GetNextToken()
        {
          
            SkipWhitespace();

            char c = CurrentChar;

           
            if (c == '\0')
            {
                return new Token(TokenType.EndOfInput, string.Empty);
            }

            
            if (char.IsDigit(c) || c == '.')
            {
                return ReadNumber();
            }

            
            if (char.IsLetter(c))
            {
                return ReadIdentifier();
            }

            
            switch (c)
            {
                case '+':
                    Advance();
                    return new Token(TokenType.Plus, "+");

                case '-':
                    Advance();
                    return new Token(TokenType.Minus, "-");

                case '*':
                    Advance();
                    return new Token(TokenType.Star, "*");

                case '/':
                    Advance();
                    return new Token(TokenType.Slash, "/");

                case '(':
                    Advance();
                    return new Token(TokenType.LParen, "(");

                case ')':
                    Advance();
                    return new Token(TokenType.RParen, ")");
            }

            
            throw new Exception("Caracter necunoscut în expresie: '" + c + "'");
        }

        private Token ReadNumber()
        {
            StringBuilder sb = new StringBuilder();
            bool hasDot = false;

            while (true)
            {
                char c = CurrentChar;

                if (char.IsDigit(c))
                {
                    sb.Append(c);
                    Advance();
                }
                else if (c == '.' && !hasDot)
                {
                    hasDot = true;
                    sb.Append(c);
                    Advance();
                }
                else
                {
                    break;
                }
            }

            return new Token(TokenType.Number, sb.ToString());
        }

        private Token ReadIdentifier()
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                char c = CurrentChar;

                if (char.IsLetter(c))
                {
                    sb.Append(c);
                    Advance();
                }
                else
                {
                    break;
                }
            }

            return new Token(TokenType.Identifier, sb.ToString());
        }
    }
}
