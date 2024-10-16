using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class BinaryExpression : Expression
    {
        private readonly Expression _lhs;

        private readonly Expression _rhs;

        private readonly TokenType _operation;

        internal BinaryExpression(Expression lhs, Expression rhs, TokenType operation) 
            => (_lhs, _rhs, _operation) = (lhs, rhs, operation);

        /// <exception cref="NotImplementedException">
        ///     Thrown when given an operation that isn't defined as a
        ///     valid binary expression
        /// </exception>
        protected override double EvalImplementation() => _operation switch
        {
            TokenType.Plus => _lhs.Eval() + _rhs.Eval(),
            TokenType.Dash => _lhs.Eval() - _rhs.Eval(),
            TokenType.Asterisk => _lhs.Eval() * _rhs.Eval(),
            TokenType.Divide => _lhs.Eval() / _rhs.Eval(),
            TokenType.Percent => _lhs.Eval() % _rhs.Eval(),
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not implemented as a binary expression")
        };

        /// <exception cref="NotImplementedException">
        ///     Thrown when given an operation that isn't defined as a
        ///     valid binary expression
        /// </exception>
        protected override string ToStringImplementation() => _operation switch
        {
            TokenType.Plus => $"{_lhs} + {_rhs}",
            TokenType.Dash => $"{_lhs} - {_rhs}",
            TokenType.Asterisk => $"{_lhs} * {_rhs}",
            TokenType.Divide => $"{_lhs} / {_rhs}",
            TokenType.Percent => $"{_lhs} % {_rhs}",
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not implemented as a binary expression")
        };
    }
}