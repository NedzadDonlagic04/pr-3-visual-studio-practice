using BasicMathExpressionParser.TokenizerStuff.Enums;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class BinaryExpression : Expression
    {
        private readonly Expression _lhs;

        private readonly Expression _rhs;

        private readonly TokenType _operation;

        protected override double EvaluateExpression() => _operation switch
        {
            TokenType.Plus => _lhs.Eval() + _rhs.Eval(),
            TokenType.Dash => _lhs.Eval() - _rhs.Eval(),
            TokenType.Asterix => _lhs.Eval() * _rhs.Eval(),
            TokenType.Divide => _lhs.Eval() / _rhs.Eval(),
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not implemented as a binary expression")
        };

        internal BinaryExpression(Expression lhs, Expression rhs, TokenType operation) 
            => (_lhs, _rhs, _operation) = (lhs, rhs, operation);
    }
}
