using NUnit.Framework;
using Combination.Core;

namespace Combination.Tests
{
    [TestFixture]
    public class CombinationCoefficientTest
    {
        [Test]
        public void GivenOneElementAndOneCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 1;
            var combinationSize = 1;
            var combinationCoefficientExpected = 1;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }
    }
}
