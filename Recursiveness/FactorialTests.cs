using NUnit.Framework;

namespace InterviewTasks.Recursiveness
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void All()
        {
            Assert.AreEqual(1, Factorial.CalculateRecursive(0));
            Assert.AreEqual(1, Factorial.CalculateRecursive(1));
            Assert.AreEqual(6, Factorial.CalculateRecursive(3));
            Assert.AreEqual(3628800, Factorial.CalculateRecursive(10));
        }
    }
}