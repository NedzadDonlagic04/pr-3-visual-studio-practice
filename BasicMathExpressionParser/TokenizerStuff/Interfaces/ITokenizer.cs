using BasicMathExpressionParser.TokenizerStuff.Classes;

namespace BasicMathExpressionParser.TokenizerStuff.Interfaces
{
    internal interface ITokenizer
    {
        public List<Token> Tokenize(string source);
    }
}
