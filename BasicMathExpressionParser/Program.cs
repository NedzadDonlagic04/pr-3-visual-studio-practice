using BasicMathExpressionParser.ParserStuff.Classes;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        internal static void Main()
        {
            Console.Write("Enter a basic math expression: ");
            string mathExpression = Console.ReadLine() ?? "";

            Parser parser = new();
            Expression expression = parser.Parse(mathExpression);

            Console.WriteLine($"Result of evaluation the expression -> {expression.Eval()}");
        }
    }
}