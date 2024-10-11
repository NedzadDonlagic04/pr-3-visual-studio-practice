using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class UnaryExpression : Expression
    {
        private readonly Expression _expression;

        private readonly TokenType _prefix;

        internal UnaryExpression(Expression expression, TokenType prefix) => (_expression, _prefix) = (expression, prefix);

        protected override double EvaluateExpression() => _prefix switch
        {
            TokenType.Plus => _expression.Eval(),
            TokenType.Dash => -_expression.Eval(),
            _ => throw new NotImplementedException($"Prefix \"{_prefix}\" is not implemented as a unary expression")
        };
}
}
