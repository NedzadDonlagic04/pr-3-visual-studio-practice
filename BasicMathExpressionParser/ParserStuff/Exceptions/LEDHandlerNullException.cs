namespace BasicMathExpressionParser.ParserStuff.Exceptions
{
    internal class LEDHandlerNullException : Exception
    {
        internal LEDHandlerNullException() { }

        internal LEDHandlerNullException(string message) : base(message) { }

        internal LEDHandlerNullException(string message, Exception inner) : base(message, inner) { }
    }
}
