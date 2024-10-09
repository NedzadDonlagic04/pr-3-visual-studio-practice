namespace BasicMathExpressionParser.TokenizerStuff
{
    internal interface ITokenizer
    {
        public List<Token> Tokenize();

        public void ResetTokenizer(string source);
    }
}
