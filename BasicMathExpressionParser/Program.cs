using BasicMathExpressionParser.TokenizerStuff;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a basic math expression: ");
            string mathExpression = Console.ReadLine() ?? "";

            Console.WriteLine(mathExpression);

            Tokenizer tokenizer = new(mathExpression);
            tokenizer.Tokenize().ForEach(token => Console.WriteLine(token));
        }
    }
}