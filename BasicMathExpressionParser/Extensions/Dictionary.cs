using System.Collections.ObjectModel;

namespace BasicMathExpressionParser.Extensions
{
    /// <summary>
    ///     I know this exists in C# 7.0 but since I was using 6.0 thought it would be
    ///     nice practice to make it myself.
    ///     <a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.collectionextensions.asreadonly?view=net-8.0">
    ///         This part of the docs mentions this stuff.
    ///     </a>
    /// </summary>

    internal static class Dictionary
    {
        internal static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(
            this Dictionary<TKey, TValue> dictionary
        ) where TKey : notnull => new(dictionary);
    }
}