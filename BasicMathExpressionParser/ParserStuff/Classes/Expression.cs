using BasicMathExpressionParser.ParserStuff.Interfaces;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class Expression : IExpression
    {
        private readonly IExpression _expression;

        /*
         * This might not be needed but I decided to add
         * a field to store the value of Eval after it's evaluated
         * once in case the expression is really big
        */
        private double? _expressionValue = null;

        internal Expression(IExpression expression) => _expression = expression;

        public double Eval()
        {
            _expressionValue ??= _expression.Eval();

            return (double)_expressionValue;
        }
    }
}
