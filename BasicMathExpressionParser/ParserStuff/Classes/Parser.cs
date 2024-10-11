using BasicMathExpressionParser.ParserStuff.Exceptions;
using BasicMathExpressionParser.ParserStuff.Interfaces;

using BasicMathExpressionParser.TokenizerStuff.Classes;
using BasicMathExpressionParser.TokenizerStuff.Interfaces;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class Parser : IParser
    {
        private readonly Tokenizer _tokenizer = new();

        private Queue<Token> _tokens = null!;

        private IExpression ParseExpression()
        {
            return new NumberExpression(5);
        }

        /// <inheritdoc cref="Tokenizer.Tokenize"/>
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

            return new Expression(ParseExpression());
        }
    }
}
