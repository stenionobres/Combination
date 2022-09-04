using NUnit.Framework;
using Combination.Core;
using System.Collections.Generic;

namespace Combination.Tests
{
    [TestFixture]
    public class CSNTests
    {
        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberTwoIsGenerated()
        {
            var totalElements = 5;
            var combination = new List<int>() { 1, 2, 3 };
            var csnExpected = 1;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }
    }
}
