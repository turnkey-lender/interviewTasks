using System;
using NUnit.Framework;

namespace InterviewTasks.SortHugeArray
{
    [TestFixture]
    public class HugeArrayTests
    {
        [Test]
        public void Correctness()
        {
            var sut = new HugeArray(20);
            sut.Sort();
            for (int i = 1; i < sut.Value.Count; i++)
            {
                Assert.That(sut.Value[i - 1] <= sut.Value[i]);
            }
        }

        [Test]
        public void Performance()
        {
            var sut = new HugeArray();
            var started = DateTime.Now;
            sut.Sort();
            var elapsed = (DateTime.Now - started).TotalSeconds;
            Console.WriteLine($"Sorting took {elapsed} seconds");
            Assert.That(elapsed < 2, "Sorting took too long...");
        }
    }
}