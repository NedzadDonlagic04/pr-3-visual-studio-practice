namespace BasicMathExpressionParser.ParserStuff.Exceptions
{
    internal class ExpectedTokenMissingException : ParserException
    {
        internal ExpectedTokenMissingException() { }

        internal ExpectedTokenMissingException(string message) : base(message) { }

        internal ExpectedTokenMissingException(string message, Exception inner) : base(message, inner) { }
    }
}