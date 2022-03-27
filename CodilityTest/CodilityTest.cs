using Codility;
using NUnit.Framework;

namespace CodilityTest
{
    public class UnitTestCodility
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BitMultiplicationTest()
        {
            var result = BitMultiplication.solution(3, 7);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void MaxDistanceTest()
        {
            Assert.AreEqual(MaxDistance.solution(new int[] { 2, 6, 8, 5 }), 3);
        }
    }
}