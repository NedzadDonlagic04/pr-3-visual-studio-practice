﻿using BasicMathExpressionParser.ParserStuff.Enums;
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
        /// <exception cref="NotImplementedException">
        ///     Thrown when the given token type doesn't have a binding power defined for it
        /// </exception>
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
        /// <exception cref="ExpectedTokenMissingException">
        ///     Thrown when the close parenthesis is missing from the exception
        /// </exception>
        private Expression ParseParenthesisExpression(Token _)
        {
            Expression expression = ParseExpression();
            Token expectedToken = EatToken();

            if (expectedToken.Type != TokenType.CloseParenthesis)
            {
                throw new ExpectedTokenMissingException(
                    $"Expected \")\" when evaluating expression but got \"{expectedToken.Value}\" instead"
                );
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
        ///     Number expressions would all have a NUD (in my case it just returns that number)
        ///     but it can also be used with unary expressions, do note even then it doesn't expect
        ///     anything to the left of it, take the expression -5, the - expects nothing to the left
        ///     of it. At least in this context.
        /// </summary>
        /// <exception cref="NotImplementedException">
        ///     Thrown when given a token type that doesn't have a defined value for it's NUD handler
        /// </exception>
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
        ///     Generally used for binary operations like multiplication (*) and division (/).
        ///     Where if you have an expression * 8 it doesn't work because * expects something
        ///     to the left of it.
        /// </summary>
        /// <exception cref="NotImplementedException">
        ///     Thrown when given a token type that doesn't have a defined value for it's LED handler
        /// </exception>
        private Func<Expression, Expression>? GetLEDHandler(TokenType tokenType) => tokenType switch
        {
            TokenType.Number or TokenType.OpenParenthesis or TokenType.CloseParenthesis => null,
            TokenType.Plus or TokenType.Dash or TokenType.Asterix or TokenType.Divide => ParseBinaryExpression,
            _ => throw new NotImplementedException($"Led handler doesn't exist for TokenType -> {tokenType}")
        };

        /// <exception cref="ExpectedTokenMissingException">
        ///     Throws this exception when there are no more tokens to eat.
        ///     Generally if this exception is thrown it means the expression
        ///     is not well formed.
        ///     An example of a situation like that could be with the expression
        ///     5 + 2 *
        ///     Where we are clearly missing a token at the end.
        /// </exception>
        private Token EatToken()
        {
            if (_tokens.Count == 0)
            {
                throw new ExpectedTokenMissingException("Expected token to eat but no more tokens exist");
            }

            return _tokens.Dequeue();
        }

        /// <exception cref="ExpectedTokenMissingException">
        ///     Throws this exception when there are no more tokens to peek.
        ///     Generally if this exception is thrown it means the expression
        ///     is not well formed.
        ///     An example of a situation like that could be with the expression
        ///     5 + 2 4
        ///     Where we are clearly missing a token between 2 and 4.
        /// </exception>
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
        /// <exception cref="NUDHandlerNullException">
        ///     Thrown when a NUD handler is null. This is an indicator that the expression
        ///     is not well formed.
        /// </exception>
        /// <exception cref="LEDHandlerNullException">
        ///     Thrown when a LED handler is null. This is an indicator that the expression
        ///     is not well formed.
        /// </exception>
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

        /// <summary>
        ///     Parses given math expression using the Pratt Parsing algorithm
        /// </summary>
        /// <inheritdoc cref="Tokenizer.Tokenize"/>
        /// <inheritdoc cref="ParseExpression"/>
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
