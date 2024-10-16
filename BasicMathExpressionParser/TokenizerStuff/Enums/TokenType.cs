namespace BasicMathExpressionParser.TokenizerStuff.Enums
{
    //[Flags] bitmasking //C# annotations/attributes
    internal enum TokenType
    {
        Number,
        MathConstant,

        Plus,
        Dash,
        
        Asterisk,
        Divide,
        Percent,

        ArrowUp,
        
        OpenParenthesis,
        CloseParenthesis,

        EndOfExpression,
    }
}