namespace BasicMathExpressionParser.ParserStuff.Exceptions
{
    internal class ParsingExpressionEmptyException : ParserException
    {
        internal ParsingExpressionEmptyException() { }

        internal ParsingExpressionEmptyException(string message) : base(message) { }

        internal ParsingExpressionEmptyException(string message, Exception inner) : base(message, inner) { }
    }
}
