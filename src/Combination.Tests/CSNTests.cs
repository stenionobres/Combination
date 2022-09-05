using NUnit.Framework;
using Combination.Core;
using System.Collections.Generic;

namespace Combination.Tests
{
    [TestFixture]
    public class CSNTests
    {
        [Test]
        public void GivenTwoElementsAndCombinationWithTwoNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 2;
            var combination = new List<int>() { 1, 2 };
            var csnExpected = 1;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTwoElementsAndCombinationWithOneNumber_WhenCSNIsCalculated_ThenNumberTwoIsGenerated()
        {
            var totalElements = 2;
            var combination = new List<int>() { 2 };
            var csnExpected = 2;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 5;
            var combination = new List<int>() { 1, 2, 3 };
            var csnExpected = 1;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberThreeIsGenerated()
        {
            var totalElements = 5;
            var combination = new List<int>() { 1, 2, 5 };
            var csnExpected = 3;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenEigthElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberThreeIsGenerated()
        {
            var totalElements = 8;
            var combination = new List<int>() { 1, 2, 5 };
            var csnExpected = 3;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumberOneHundredEightyNineIsGenerated()
        {
            var totalElements = 10;
            var combination = new List<int>() { 2, 5, 7, 8, 10 };
            var csnExpected = 189;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumber_1424_IsGenerated()
        {
            var totalElements = 15;
            var combination = new List<int>() { 2, 5, 7, 8, 10 };
            var csnExpected = 1424;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 15;
            var combination = new List<int>() { 1, 2, 3, 4, 5 };
            var csnExpected = 1;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumber_3003_IsGenerated()
        {
            var totalElements = 15;
            var combination = new List<int>() { 11, 12, 13, 14, 15 };
            var csnExpected = 3003;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumberFiveIsGenerated()
        {
            var totalElements = 60;
            var combination = new List<int>() { 1, 2, 3, 4, 5, 10 };
            var csnExpected = 5;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 25;
            var combination = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var csnExpected = 1;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_737432_IsGenerated()
        {
            var totalElements = 25;
            var combination = new List<int>() { 1, 2, 4, 5, 6, 11, 13, 14, 15, 16, 20, 21, 23, 24, 25 };
            var csnExpected = 737432;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_940577_IsGenerated()
        {
            var totalElements = 25;
            var combination = new List<int>() { 1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            var csnExpected = 940577;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_3268760_IsGenerated()
        {
            var totalElements = 25;
            var combination = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            var csnExpected = 3268760;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }
    }
}
