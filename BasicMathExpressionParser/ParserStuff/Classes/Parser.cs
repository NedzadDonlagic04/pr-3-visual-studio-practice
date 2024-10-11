using BasicMathExpressionParser.ParserStuff.Enums;
using BasicMathExpressionParser.ParserStuff.Exceptions;
using BasicMathExpressionParser.ParserStuff.Interfaces;

using BasicMathExpressionParser.TokenizerStuff.Classes;
using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class Parser : IParser
    {
        private readonly Tokenizer _tokenizer = new();

        private Queue<Token> _tokens = null!;

        /// <summary>
        ///     Returns the precedence of each token type which helps when parsing
        ///     to make sure the order is correct
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private TokenBindingPower GetTokenBindingPower(TokenType tokenType) => tokenType switch
        {
            TokenType.Number => TokenBindingPower.Literal,
            TokenType.Plus or TokenType.Dash => TokenBindingPower.Additive,
            TokenType.Asterix or TokenType.Divide => TokenBindingPower.Multiplicative,
            TokenType.OpenParenthesis => TokenBindingPower.Parenthesis,
            TokenType.CloseParenthesis => TokenBindingPower.Minimum,
            _ => throw new NotImplementedException($"Token binding power doesn't exist for TokenType -> {tokenType}")
        };


        private NumberExpression ParserNumberToken(Token token) => new(double.Parse(token.Value));

        /// <inheritdoc cref="ParseExpression"/>
        /// <exception cref="ExpectedTokenMissingException"></exception>
        private Expression ParseParenthesisExpression(Token _)
        {
            Expression expression = ParseExpression();
            Token expectedToken = EatToken();

            if (expectedToken.Type != TokenType.CloseParenthesis)
            {
                throw new ExpectedTokenMissingException($"Expected {expectedToken.Value} when evaluating expression but is missing");
            }

            return expression;
        }

        /// <inheritdoc cref="ParseExpression"/>
        private UnaryExpression ParseUnaryExpression(Token prefix)
            => new(ParseExpression(GetTokenBindingPower(prefix.Type)), prefix.Type);

        /// <summary>
        ///     NUD -> NUll Denotation
        ///     If it returns a function, it should be able to parse a token and expect nothing
        ///     to the left of it
        ///     Some examples of operations like that are sign operators plus (+) and minus (-)
        ///     Not to be confused with their LED counterparts which expect an operator to the left
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private Func<Token, Expression>? GetNUDHandler(TokenType tokenType) => tokenType switch
        {
            TokenType.Number => ParserNumberToken,
            TokenType.Plus or TokenType.Dash => ParseUnaryExpression,
            TokenType.OpenParenthesis => ParseParenthesisExpression,
            TokenType.Asterix or TokenType.Divide or TokenType.CloseParenthesis => null,
            _ => throw new NotImplementedException($"Nud handler doesn't exist for TokenType -> {tokenType}")
        };

        /// <inheritdoc cref="ParseExpression"/>
        private BinaryExpression ParseBinaryExpression(Expression lhs)
        {
            TokenType operationType = EatToken().Type;

            return new(lhs, ParseExpression(GetTokenBindingPower(operationType)), operationType);
        }

        /// <summary>
        ///     LED -> LEft Denotation
        ///     If it returns a function, it should be able to parse a token and expect something
        ///     to the left of it
        ///     Some examples of operations like that are multiplication (*) and division (/)
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private Func<Expression, Expression>? GetLEDHandler(TokenType tokenType) => tokenType switch
        {
            TokenType.Number or TokenType.OpenParenthesis or TokenType.CloseParenthesis => null,
            TokenType.Plus or TokenType.Dash or TokenType.Asterix or TokenType.Divide => ParseBinaryExpression,
            _ => throw new NotImplementedException($"Led handler doesn't exist for TokenType -> {tokenType}")
        };

        /// <exception cref="ExpectedTokenMissingException"></exception>
        private Token EatToken()
        {
            if (_tokens.Count == 0)
            {
                throw new ExpectedTokenMissingException("Expected token to eat but no more tokens exist");
            }

            return _tokens.Dequeue();
        }

        /// <exception cref="ExpectedTokenMissingException"></exception>
        private Token PeekToken()
        {
            if (_tokens.Count == 0)
            {
                throw new ExpectedTokenMissingException("Expected token to peek but no more tokens exist");
            }

            return _tokens.Peek();
        }

        private bool ContinueParsingTokens(TokenBindingPower bindingPower) 
            => _tokens.Count != 0 && GetTokenBindingPower(PeekToken().Type) > bindingPower;

        /// <inheritdoc cref="EatToken"/>
        /// <inheritdoc cref="PeekToken"/>
        /// <exception cref="NUDHandlerNullException"></exception>
        /// <exception cref="LEDHandlerNullException"></exception>
        private Expression ParseExpression(TokenBindingPower bindingPower = TokenBindingPower.Minimum)
        {
            Token currentToken = EatToken();
            var currentNUDHandler = GetNUDHandler(currentToken.Type);

            if (currentNUDHandler == null)
            {
                throw new NUDHandlerNullException($"Expected NUD handler for {currentToken}");
            }

            var lhs = currentNUDHandler(currentToken);

            while (ContinueParsingTokens(bindingPower))
            {
                var currentLEDHandler = GetLEDHandler(PeekToken().Type);

                if (currentLEDHandler == null)
                {
                    throw new LEDHandlerNullException($"Expected LED handler for {PeekToken()}");
                }

                lhs = currentLEDHandler(lhs);
            }

            return lhs;
        }

        /// <inheritdoc cref="Tokenizer.Tokenize"/>
        /// <inheritdoc cref="ParseExpression"/>
        /// <summary>
        ///     Parses given math expression using the Pratt Parsing algorithm
        /// </summary>
        /// <exception cref="ParsingExpressionEmptyException">
        ///     Thrown when the parser receives as empty expression to parse
        /// </exception>
        public Expression Parse(string source)
        {
            if (source == "")
            {
                throw new ParsingExpressionEmptyException($"The expression to parse is empty");
            }

            _tokens = _tokenizer.Tokenize(source);

            return ParseExpression();
        }
    }
}
