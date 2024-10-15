using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.TokenizerStuff.Classes
{
    internal struct Token
    {
        internal string Value { get; private set; }

        internal TokenType Type { get; private set; }

        internal Token(string value, TokenType type) => (Value, Type) = (value, type);

        public override string ToString() => $"{Type}Token -> {Value}";
    }
}
