using System.Text;

namespace BasicMathExpressionParser.TokenizerStuff
{
    internal class Tokenizer : ITokenizer
    {
        private readonly List<Token> _tokens = new();

        private StringBuilder _source;

        internal Tokenizer(string source) => _source = new(source);

        public void ResetTokenizer(string source)
        {
            _source = new(source);
            _tokens.Clear();
        }

        public List<Token> Tokenize() => new();
    }
}
