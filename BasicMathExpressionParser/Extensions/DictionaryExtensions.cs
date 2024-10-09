using System.Collections.ObjectModel;

namespace BasicMathExpressionParser.Extensions
{
    internal static class DictionaryExtensions
    {
        internal static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(
            this Dictionary<TKey, TValue> dictionary
        ) where TKey : notnull => new(dictionary);
    }
}
