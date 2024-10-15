namespace BasicMathExpressionParser.TokenizerStuff.Exceptions
{
    internal class TokenizerException : Exception
    {
        internal TokenizerException() { }

        internal TokenizerException(string message) : base(message) { }

        internal TokenizerException(string message, Exception inner) : base(message, inner) { }
    }
}