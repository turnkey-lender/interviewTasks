using NUnit.Framework;

namespace InterviewTasks.MatchBraces
{
    [TestFixture]
    public class BracesTests
    {
        [Test]
        public void Positive()
        {
            Assert.IsTrue(Braces.Match("()"));
            Assert.IsTrue(Braces.Match("(1+2)-(3+4)"));
            Assert.IsTrue(Braces.Match("(a(b(c)))"));
        }

        [Test]
        public void Negative()
        {
            Assert.IsFalse(Braces.Match("(1+2"));
            Assert.IsFalse(Braces.Match("1+2)"));
            Assert.IsFalse(Braces.Match(")("));
            Assert.IsFalse(Braces.Match("(a(b(c))"));
        }
    }
}