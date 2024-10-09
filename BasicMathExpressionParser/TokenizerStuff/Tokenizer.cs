﻿using System.Text;
using System.Text.RegularExpressions;

namespace BasicMathExpressionParser.TokenizerStuff
{
    internal class Tokenizer : ITokenizer
    {
        private readonly List<Token> _tokens = new();

        private StringBuilder _source;

        private readonly Dictionary<string, TokenType?> _tokenPatterns = new()
        {
            { @"^\d+(.\d+)?", TokenType.Number },
            { @"^\+", TokenType.Plus },
            { @"^-", TokenType.Dash },
            { @"^\*", TokenType.Asterix },
            { @"^\/", TokenType.Divide },

            // Patterns below have a null value for TokenType
            // Because these patterns are intended to just be eaten
            { @"^\s+", null },
        };

        internal Tokenizer(string source) => _source = new(source);

        public void ResetTokenizer(string source)
        {
            _source = new(source);
            _tokens.Clear();
        }

        public List<Token> Tokenize()
        {
            while (_source.Length != 0)
            {
                foreach (var (pattern, tokenType) in _tokenPatterns)
                {
                    var matchResult = Regex.Match(_source.ToString(), pattern);

                    if (!matchResult.Success)
                    {
                        continue;
                    }
                    else if (tokenType != null)
                    {
                        _tokens.Add(new(matchResult.Value, (TokenType)tokenType));
                    }

                    _source.Remove(0, matchResult.Value.Length);
                }
            }

            return _tokens;
        }
    }
}
