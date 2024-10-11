using BasicMathExpressionParser.Extensions;

using BasicMathExpressionParser.TokenizerStuff.Enums;
using BasicMathExpressionParser.TokenizerStuff.Exceptions;
using BasicMathExpressionParser.TokenizerStuff.Interfaces;

using System.Collections.ObjectModel;

using System.Text;
using System.Text.RegularExpressions;

namespace BasicMathExpressionParser.TokenizerStuff.Classes
{
    internal class Tokenizer : ITokenizer
    {
        private readonly Queue<Token> _tokens = new();

        private StringBuilder _source = new();

        private static readonly ReadOnlyDictionary<string, TokenType?> _tokenPatterns;

        static Tokenizer()
        {
            Dictionary<string, TokenType?> tokenPatterns = new()
            {
                { @"^\d+(\.\d+)?", TokenType.Number },
                
                { @"^\+", TokenType.Plus },
                { @"^-", TokenType.Dash },

                { @"^\*", TokenType.Asterix },
                { @"^\/", TokenType.Divide },
                
                { @"^\(", TokenType.OpenParenthesis },
                { @"^\)", TokenType.CloseParenthesis },

                // Patterns below have a null value for TokenType
                // Because these patterns are intended to just be eaten
                { @"^\s+", null },
            };

            _tokenPatterns = tokenPatterns.AsReadOnly();
        }

        private void ResetTokenizer(string source)
        {
            _source = new(source);
            _tokens.Clear();
        }

        /// <summary>
        ///     Tokenizes source using pre defined token patterns
        /// </summary>
        /// <exception cref="TokenizerUnhandledPatternException">
        ///     Thrown when a token pattern isn't recognized by the tokenizer
        /// </exception>
        public Queue<Token> Tokenize(string source)
        {
            ResetTokenizer(source);

            while (_source.Length != 0)
            {
                string sourceBefore = _source.ToString();

                foreach (var (pattern, tokenType) in _tokenPatterns)
                {
                    var matchResult = Regex.Match(_source.ToString(), pattern);

                    if (!matchResult.Success)
                    {
                        continue;
                    }
                    else if (tokenType != null)
                    {
                        _tokens.Enqueue(new(matchResult.Value, (TokenType)tokenType));
                    }

                    _source.Remove(0, matchResult.Value.Length);
                }

                if (sourceBefore == _source.ToString())
                {
                    throw new TokenizerUnhandledPatternException(
                        $"Unhandled pattern \"{sourceBefore}\" encountered in expression"
                    );
                }
            }

            return _tokens;
        }
    }
}
