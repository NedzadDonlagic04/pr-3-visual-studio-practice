using BasicMathExpressionParser.TokenizerStuff.Classes;
using BasicMathExpressionParser.TokenizerStuff.Exceptions;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a basic math expression: ");
            string mathExpression = Console.ReadLine() ?? "";

            Tokenizer tokenizer = new(mathExpression);

            try
            {
                tokenizer.Tokenize().ForEach(token => Console.WriteLine(token));
            }
            catch(TokenizerException ex)
            {
                Console.Write("Error encountered -> ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}