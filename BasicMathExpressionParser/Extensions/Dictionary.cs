using System.Collections.ObjectModel;

namespace BasicMathExpressionParser.Extensions
{
    // I know this exists in C# 7.0 but since I was using 6.0 thought it would be
    // nice practice to make it myself, this the docs below are a nice source
    // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.collectionextensions.asreadonly?view=net-8.0
    internal static class Dictionary
    {
        internal static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(
            this Dictionary<TKey, TValue> dictionary
        ) where TKey : notnull => new(dictionary);
    }
}
