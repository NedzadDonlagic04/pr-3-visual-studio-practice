using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class UnaryExpression : Expression
    {
        private readonly Expression _expression;

        private readonly TokenType _prefix;

        internal UnaryExpression(Expression expression, TokenType prefix) => (_expression, _prefix) = (expression, prefix);

        /// <exception cref="NotImplementedException">
        ///     Thrown when given a prefix that isn't defined as a part of
        ///     any unary expression
        /// </exception>
        protected override double EvalImplementation() => _prefix switch
        {
            TokenType.Plus => _expression.Eval(),
            TokenType.Dash => -_expression.Eval(),
            _ => throw new NotImplementedException($"Prefix \"{_prefix}\" is not implemented as a unary expression")
        };

        /// <exception cref="NotImplementedException">
        ///     Thrown when given a prefix that isn't defined as a part of
        ///     any unary expression
        /// </exception>
        protected override string ToStringImplementation() => _prefix switch
        {
            TokenType.Plus => $"+{_expression.Eval()}",
            TokenType.Dash => $"-{_expression.Eval()}",
            _ => throw new NotImplementedException($"Prefix \"{_prefix}\" is not implemented as a unary expression")
        };
    }
}