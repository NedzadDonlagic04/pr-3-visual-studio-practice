namespace BasicMathExpressionParser.ParserStuff.Enums
{
    internal enum TokenBindingPower : byte
    {
        Minimum,
        Literal,        // Stuff like Number, if string literals ever get added could use this same thing
        Additive,
        Multiplicative,
        Exponential,
        Parenthesis,
        Maximum,
    }
}