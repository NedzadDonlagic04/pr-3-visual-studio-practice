namespace BasicMathExpressionParser.TokenizerStuff.Enums
{
    internal enum TokenType : byte
    {
        Number,
        MathConstant,

        Plus,
        Dash,
        
        Asterix,
        Divide,
        Percent,

        ArrowUp,
        
        OpenParenthesis,
        CloseParenthesis,

        EndOfExpression,
    }
}
