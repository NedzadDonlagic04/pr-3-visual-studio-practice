using BasicMathExpressionParser.ParserStuff.Interfaces;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class NumberExpression : IExpression
    {
        private readonly double _value;

        internal NumberExpression(double value) => _value = value;

        public double Eval() => _value;
    }
}
