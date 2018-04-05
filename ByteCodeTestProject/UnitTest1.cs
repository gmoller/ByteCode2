using ByteCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ByteCodeTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EvaluateNumberExpression()
        {
            IExpression expression = new NumberExpression(5);

            Assert.AreEqual(5, expression.Evaluate());
        }

        [TestMethod]
        public void EvaluateAdditionExpression()
        {
            IExpression expression = new AdditionExpression(new NumberExpression(3), new NumberExpression(2));

            Assert.AreEqual(5, expression.Evaluate());
        }
    }
}