using BasicMathExpressionParser.Extensions;

using System.Collections.ObjectModel;

namespace BasicMathExpressionParser.ParserStuff.Classes
{
    internal class MathConstantExpression : Expression
    {
        private readonly double _value;

        private static readonly ReadOnlyDictionary<string, double> _supportedMathConstants;

        private static readonly string _supportedMathConstantNamesJoined;

        static MathConstantExpression()
        {
            Dictionary<string, double> supportedMathConstants = new();
            // Attempt to get all constants from the Math class since
            // I wanna support just those
            foreach (var field in typeof(Math).GetFields())
            {
                if (field.IsLiteral)
                {
                    string key = field.Name.ToLower();
                    double value = (double)(field.GetValue(null) ?? 0);

                    supportedMathConstants.Add(key, value);
                }
            }

            _supportedMathConstants = supportedMathConstants.AsReadOnly();

            string separator = ", ";
            _supportedMathConstantNamesJoined = string.Join(
                separator, 
                _supportedMathConstants.Select(pair => pair.Key.ToString())
            );
        }

        /// <exception cref="NotImplementedException">
        ///     Thrown when the passed constant name is not supported
        /// </exception>
        internal MathConstantExpression(string value)
        {
            string key = value.ToLower();

            if (!_supportedMathConstants.ContainsKey(key))
            {
                throw new NotImplementedException($"The math constant \"{value}\" is not supported. " + 
                $"The supported ones are: {_supportedMathConstantNamesJoined}");
            }

            _value = _supportedMathConstants[key];
        }

        protected override double EvalImplementation() => _value;

        protected override string ToStringImplementation() => _value.ToString();
    }
}
