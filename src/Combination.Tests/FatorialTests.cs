using NUnit.Framework;
using Combination.Core;

namespace Combination.Tests
{
    [TestFixture]
    public class FatorialTests
    {
        [Test]
        public void GivenNumberZero_WhenFatorialIsCalculated_ThenNumberOneIsGenerated()
        {
            var number = 0;
            var fatorialExpected = 1;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }
    }
}
