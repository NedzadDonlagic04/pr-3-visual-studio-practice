namespace BasicMathExpressionParser.ParserStuff.Exceptions
{
    internal class NUDHandlerNullException : ParserException
    {
        internal NUDHandlerNullException() { }

        internal NUDHandlerNullException(string message) : base(message) { }

        internal NUDHandlerNullException(string message, Exception inner) : base(message, inner) { }
    }
}
