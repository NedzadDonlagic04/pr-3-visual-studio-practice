namespace WinFormsCalculator.Classes
{
    internal class CalculatorHistory
    {
        private readonly List<Expression> _expressions = new();

        internal void Add(string expression, double result) 
            => _expressions.Add(new Expression(expression, result));

        internal List<Expression> GetHistory() => _expressions;

        public override string ToString() => string.Join('\n', _expressions);
    }
}
