using BasicMathExpressionParser.TokenizerStuff.Classes;

namespace BasicMathExpressionParser.TokenizerStuff.Interfaces
{
    internal interface ITokenizer
    {
        public Queue<Token> Tokenize(string source);
    }
}