using BasicMathExpressionParser.ParserStuff.Classes;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        private static readonly string[] _quitStrOptions = new string[] { "quit", "exit" };

        private static readonly Parser _parser = new();

        private static void ParseMathExpressionAndPrintResult(string mathExpressionStr)
        {
            try
            {
                Expression expression = _parser.Parse(mathExpressionStr);

                Console.WriteLine($"Result of evaluation the expression {expression} -> {expression.Eval()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void Main()
        {
            string mathExpressionStr;

            while (true)
            {
                Console.Write("Enter a basic math expression: ");
                mathExpressionStr = Console.ReadLine() ?? "";

                if (_quitStrOptions.Contains(mathExpressionStr.ToLower()))
                {
                    break;
                }

                ParseMathExpressionAndPrintResult(mathExpressionStr);
                
                Console.WriteLine();
            }
        }
    }
}