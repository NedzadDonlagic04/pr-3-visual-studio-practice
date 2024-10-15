namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class ExponentExpression : Expression
    {
        private readonly Expression _lhs;

        private readonly Expression _rhs;

        public ExponentExpression(Expression lhs, Expression rhs) => (_lhs, _rhs) = (lhs, rhs);

        protected override double EvalImplementation() => Math.Pow(_lhs.Eval(), _rhs.Eval());

        protected override string ToStringImplementation() => $"{_lhs.Eval()}^{_rhs.Eval()}";
    }
}