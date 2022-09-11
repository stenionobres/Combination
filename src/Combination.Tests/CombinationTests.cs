using NUnit.Framework;
using System.Collections.Generic;

namespace Combination.Tests
{
    [TestFixture]
    public class CombinationTests
    {
        [Test]
        public void GivenTotalElementsLessThanCombinationSize_WhenCSNIsCalculated_ThenNumberZeroIsGenerated()
        {
            var csnExpected = 0;
            var combination = new Core.Combination(totalElements: 0, combinationSize: 2);
            combination.buildWith(elements: new List<int> { 1, 2 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }
    }
}
