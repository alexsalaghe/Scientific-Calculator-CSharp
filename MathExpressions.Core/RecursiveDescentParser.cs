using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions.Core
{
    public class RecursiveDescentParser : IExpressionParser
    {
        private readonly FunctionRegistry _functionRegistry;
        private Lexer _lexer;
        private Token _currentToken;

        public RecursiveDescentParser(FunctionRegistry functionRegistry)
        {
            _functionRegistry = functionRegistry ?? throw new ArgumentNullException(nameof(functionRegistry));
        }

        public ExpressionNode Parse(string expressionText)
        {
            if (expressionText == null)
            {
                throw new ArgumentNullException(nameof(expressionText));
            }

            _lexer = new Lexer(expressionText);
            _currentToken = _lexer.GetNextToken();

            ExpressionNode expr = ParseExpression();

            if (_currentToken.Type != TokenType.EndOfInput)
            {
                throw new ParserException("Token neașteptat la finalul expresiei: " + _currentToken.Text);
            }

            return expr;
        }

        
        private ExpressionNode ParseExpression()
        {
            ExpressionNode node = ParseTerm();

            while (_currentToken.Type == TokenType.Plus ||
                   _currentToken.Type == TokenType.Minus)
            {
                Token op = _currentToken;
                Eat(op.Type);

                ExpressionNode right = ParseTerm();

                BinaryOperatorType opType;
                if (op.Type == TokenType.Plus)
                {
                    opType = BinaryOperatorType.Add;
                }
                else
                {
                    opType = BinaryOperatorType.Subtract;
                }

                node = new BinaryOperatorNode(node, right, opType);
            }

            return node;
        }

        
        private ExpressionNode ParseTerm()
        {
            ExpressionNode node = ParseFactor();

            while (_currentToken.Type == TokenType.Star ||
                   _currentToken.Type == TokenType.Slash)
            {
                Token op = _currentToken;
                Eat(op.Type);

                ExpressionNode right = ParseFactor();

                BinaryOperatorType opType;
                if (op.Type == TokenType.Star)
                {
                    opType = BinaryOperatorType.Multiply;
                }
                else
                {
                    opType = BinaryOperatorType.Divide;
                }

                node = new BinaryOperatorNode(node, right, opType);
            }

            return node;
        }

       
        private ExpressionNode ParseFactor()
        {
            if (_currentToken.Type == TokenType.Plus ||
                _currentToken.Type == TokenType.Minus)
            {
                Token op = _currentToken;
                Eat(op.Type);

                ExpressionNode operand = ParseFactor();

                UnaryOperatorType uType;
                if (op.Type == TokenType.Plus)
                {
                    uType = UnaryOperatorType.Plus;
                }
                else
                {
                    uType = UnaryOperatorType.Minus;
                }

                return new UnaryOperatorNode(operand, uType);
            }

            return ParsePrimary();
        }

      
        private ExpressionNode ParsePrimary()
        {
            switch (_currentToken.Type)
            {
                case TokenType.Number:
                    double value;
                    if (!double.TryParse(_currentToken.Text, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out value))
                    {
                        
                        value = double.Parse(_currentToken.Text);
                    }

                    Eat(TokenType.Number);
                    return new NumberNode(value);

                case TokenType.Identifier:
                    return ParseFunctionCall();

                case TokenType.LParen:
                    Eat(TokenType.LParen);
                    ExpressionNode inner = ParseExpression();
                    Eat(TokenType.RParen);
                    return inner;

                default:
                    throw new ParserException("Token neașteptat: " + _currentToken.ToString());
            }
        }

        private ExpressionNode ParseFunctionCall()
        {
            string funcName = _currentToken.Text;
            Eat(TokenType.Identifier);

            Eat(TokenType.LParen);
            ExpressionNode arg = ParseExpression();
            Eat(TokenType.RParen);

            IMathFunction func = _functionRegistry.FindByName(funcName);
            if (func == null)
            {
                throw new ParserException("Funcție necunoscută: " + funcName);
            }

            return new FunctionNode(func, arg);
        }

        private void Eat(TokenType expectedType)
        {
            if (_currentToken.Type == expectedType)
            {
                _currentToken = _lexer.GetNextToken();
            }
            else
            {
                throw new ParserException(
                    string.Format("Așteptam tokenul {0}, dar am găsit {1}", expectedType, _currentToken.Type));
            }
        }
    }
}
