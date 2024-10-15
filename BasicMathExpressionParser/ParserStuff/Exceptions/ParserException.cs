namespace BasicMathExpressionParser.ParserStuff.Exceptions
{
    internal class ParserException : Exception
    {
        internal ParserException() { }
        
        internal ParserException(string message) : base(message) { }
        
        internal ParserException(string message, Exception inner) : base(message, inner) { }
    }
}