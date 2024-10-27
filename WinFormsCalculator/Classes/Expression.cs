namespace WinFormsCalculator.Classes
{
    internal class Expression
    {
        private readonly string _expression;

        internal double Result { get; private set; }

        internal Expression(string expression, double result) => (_expression, Result) = (expression, result);

        public override string ToString() => _expression;
    }
}
