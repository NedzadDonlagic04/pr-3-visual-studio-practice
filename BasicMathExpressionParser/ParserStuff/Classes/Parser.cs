using BasicMathExpressionParser.ParserStuff.Interfaces;

using BasicMathExpressionParser.TokenizerStuff.Classes;
using BasicMathExpressionParser.TokenizerStuff.Interfaces;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class Parser : IParser
    {
        private readonly Tokenizer _tokenizer = new();

        public Expression Parse(string source) => new(new NumberExpression(5));
    }
}
