using BasicMathExpressionParser.TokenizerStuff.Classes;
using BasicMathExpressionParser.TokenizerStuff.Enums;
using BasicMathExpressionParser.TokenizerStuff.Interfaces;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BasicMathExpressionParserTests
{
    [TestClass]
    public class TokenizerTests
    {
        private readonly ITokenizer _tokenizer = new Tokenizer();

        [TestMethod]
        public void Tokenize_WithALotOfSpaces()
        {
            // Arrange
            Queue<Token> expectedTokens = new();
            expectedTokens.Enqueue(new Token("3", TokenType.Number));
            expectedTokens.Enqueue(new Token("*", TokenType.Asterix));
            expectedTokens.Enqueue(new Token("(", TokenType.OpenParenthesis));
            expectedTokens.Enqueue(new Token("-", TokenType.Dash));
            expectedTokens.Enqueue(new Token("4", TokenType.Number));
            expectedTokens.Enqueue(new Token(")", TokenType.CloseParenthesis));
            expectedTokens.Enqueue(new Token("+", TokenType.Plus));
            expectedTokens.Enqueue(new Token("(", TokenType.OpenParenthesis));
            expectedTokens.Enqueue(new Token("5", TokenType.Number));
            expectedTokens.Enqueue(new Token("*", TokenType.Asterix));
            expectedTokens.Enqueue(new Token("12", TokenType.Number));
            expectedTokens.Enqueue(new Token(")", TokenType.CloseParenthesis));
            expectedTokens.Enqueue(new Token("", TokenType.EndOfExpression));

            // Act
            var actualTokens = _tokenizer.Tokenize(" 3    * (  - 4 ) + (5 * 12)   ");

            // Assert
            Assert.That(actualTokens, Is.EqualTo(expectedTokens));
        }
    }
}