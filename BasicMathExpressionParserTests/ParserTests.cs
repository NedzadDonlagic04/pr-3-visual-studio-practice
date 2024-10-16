using BasicMathExpressionParser.ParserStuff.Classes;

using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BasicMathExpressionParserTests
{
    [TestClass]
    public class ParserTests
    {
        Parser _parser = new();

        [TestMethod]
        public void Parse_MathExpression1()
        {
            // Arrange
            string mathExpressionStr = "5 + 16 - (2 + 5) % 2";

            // Act
            Expression expression = _parser.Parse(mathExpressionStr);

            // Assert
            Assert.That(expression.Eval(), Is.EqualTo(20));
        }
    }
}
