using BasicMathExpressionParser.ParserStuff.Classes;

namespace BasicMathExpressionParser
{
    internal class Program
    {
        private static readonly Parser _parser = new();

        private static readonly string[] _validExitingProgramInputs = new string[] { "exit", "quit" };

        private static void ParseMathExpression(string mathExpressionStr)
        {
            try
            {
                Expression expression = _parser.Parse(mathExpressionStr);
                Console.WriteLine($"Result of evaluation the expression -> {expression.Eval()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }

        internal static void Main()
        {
            Console.WriteLine("If you wish to stop the execution of the program enter one "
             + "of the following words (all uppercase or lowercase doesn't matter):");
            foreach(var validExitProgramInput in _validExitingProgramInputs)
            {
                Console.WriteLine($"- {validExitProgramInput}");
            }
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter a basic math expression: ");
                string input = Console.ReadLine() ?? "";

                if (_validExitingProgramInputs.Contains(input.ToLower()))
                {
                    break;
                }

                ParseMathExpression(input);
            }
        }
    }
}