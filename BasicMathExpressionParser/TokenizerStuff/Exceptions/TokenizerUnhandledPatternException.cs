namespace BasicMathExpressionParser.TokenizerStuff.Exceptions
{
    internal class TokenizerUnhandledPatternException : TokenizerException
    {
        internal TokenizerUnhandledPatternException() { }
        
        internal TokenizerUnhandledPatternException(string message) : base(message) { }
        
        internal TokenizerUnhandledPatternException(string message, Exception inner) : base(message, inner) { }
    }
}