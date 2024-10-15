namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal abstract class Expression
    {
        /// <summary>
        ///     Field used to store the value after calling EvalImplementation
        ///     doing this to prevent uneccessary calculations since whatever
        ///     inherits Expression should not be mutable (for the value at least)
        /// </summary>
        private double? _evalValueCache = null;

        /// <summary>
        ///     Similar case to _evalValueCache just for the string version
        ///     of the expression
        /// </summary>
        private string? _toStringValueCache = null;

        private bool _expressionInsideParanthesis = false;
        public bool ExpressionInsideParanthesis 
        { 
            get => _expressionInsideParanthesis; 
            set {
                if (_expressionInsideParanthesis == value)
                {
                    return;
                }

                _expressionInsideParanthesis = value;
                _toStringValueCache = null;
            } 
        }

        /// <summary>
        ///     Intended to actually evaluate the expression by going through
        ///     the whole thing, unlike Eval which will store it's value to
        ///     prevent calculating multiple times for the same value
        /// </summary>
        /// <returns>Value from the evaluated expression</returns>
        protected abstract double EvalImplementation();

        /// <summary>
        ///     The idea for this method was to have whoever uses any derived class
        ///     call this one which would try to ensure that the evaluation doesn't
        ///     happen more than once by storing it in a field
        /// </summary>
        /// <returns>Value from the evaluated expression</returns>
        public double Eval()
        {
            _evalValueCache ??= EvalImplementation();

            return (double)_evalValueCache;
        }

        protected abstract string ToStringImplementation();

        public sealed override string ToString() 
        {
            _toStringValueCache ??= (ExpressionInsideParanthesis ? $"({ToStringImplementation()})" : ToStringImplementation());

            return _toStringValueCache;
        }
    }
}