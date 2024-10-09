namespace BasicMathExpressionParser.TokenizerStuff
{
    internal enum TokenType
    {
        Number,
        Plus,
        Dash,
        Asterix,
        Divide,
    }

    internal class Token
    {
        internal string Value { get; private set; }

        internal TokenType Type { get; private set; }

        internal Token(string value, TokenType type) => (Value, Type) = (value, type);

        public override string ToString() => $"{Type}Token -> {Value}";
    }
}
