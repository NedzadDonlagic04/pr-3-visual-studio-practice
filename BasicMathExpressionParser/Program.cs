using BasicMathExpressionParser.ParserStuff.Classes;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        internal static void Main()
        {
            Parser parser = new();

            Expression expression = parser.Parse("Random giberish does nothing");

            Console.WriteLine(expression.Eval());
        }
    }
}