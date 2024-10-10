using BasicMathExpressionParser.ParserStuff.Classes;

namespace BasicMathExpressionParser.ParserStuff.Interfaces
{
    internal interface IParser
    {
        public Expression Parse(string source);
    }
}
