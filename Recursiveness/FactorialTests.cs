using NUnit.Framework;

namespace InterviewTasks.Recursiveness
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void All()
        {
            Assert.AreEqual(1, Factorial.Calculate(0));
            Assert.AreEqual(1, Factorial.Calculate(1));
            Assert.AreEqual(6, Factorial.Calculate(3));
            Assert.AreEqual(3628800, Factorial.Calculate(10));
        }
    }
}