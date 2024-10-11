namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal abstract class Expression
    {
        /// <summary>
        ///     Field used to store the value after it evaluates once
        ///     to prevent multiple evaluations
        /// </summary>
        private double? _expressionValue = null;

        /// <summary>
        ///     Intended to actually evaluate the expression by going through
        ///     the whole thing, unlike Eval which will store it's value to
        ///     prevent calculating multiple times for the same value
        /// </summary>
        /// <returns>Value from the evaluated expression</returns>
        protected abstract double EvaluateExpression();

        /// <summary>
        ///     The idea for this method was to have whoever uses any derived class
        ///     call this one which would try to ensure that the evaluation doesn't
        ///     happen more than once by storing it in a field
        /// </summary>
        /// <returns>Value from the evaluated expression</returns>
        public double Eval()
        {
            _expressionValue ??= EvaluateExpression();

            return (double)_expressionValue;
        }
    }
}
