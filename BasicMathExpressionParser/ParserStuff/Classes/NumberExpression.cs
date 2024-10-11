namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class NumberExpression : Expression
    {
        private readonly double _value;

        internal NumberExpression(double value) => _value = value;

        protected override double EvaluateExpression() => _value;
    }
}
