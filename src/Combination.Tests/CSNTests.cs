using System;
using System.Linq;
using NUnit.Framework;
using Combination.Core;
using System.Collections.Generic;

namespace Combination.Tests
{
    [TestFixture]
    public class CSNTests
    {
        [Test]
        public void GivenTotalElementsEqualZero_WhenCSNIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 0;
            List<int> combination = new List<int> { 1, 2 };

            var exception = Assert.Throws<ApplicationException>(() => CSN.Calculate(totalElements, combination));

            Assert.That(exception.Message, Is.EqualTo("Total elements must be greater than 0"));
        }

        [Test]
        public void GivenANullCombination_WhenCSNIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 0;
            List<int> combination = null;

            var exception = Assert.Throws<ApplicationException>(() => CSN.Calculate(totalElements, combination));

            Assert.That(exception.Message, Is.EqualTo("Combination parameter cannot be null"));
        }

        [Test]
        public void GivenCombinationSizeGreaterThanTotalElements_WhenCSNIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 2;
            List<int> combination = new List<int> { 1, 2, 3 };

            var exception = Assert.Throws<ApplicationException>(() => CSN.Calculate(totalElements, combination));

            Assert.That(exception.Message, Is.EqualTo("Total elements must be greater than or equal combination size"));
        }

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
        public void GivenFiveElementsAndCombinationWithThreeNumbersNotOrdered_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 5;
            var combination = new List<int>() { 1, 3, 2 };
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
        public void GivenFifteenElementsAndCombinationWithFiveNumbersNotOrdered_WhenCSNIsCalculated_ThenNumber_1424_IsGenerated()
        {
            var totalElements = 15;
            var combination = new List<int>() { 2, 7, 5, 10, 8 };
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
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_34804260_IsGenerated()
        {
            var totalElements = 60;
            var combination = new List<int>() { 11, 15, 25, 38, 44, 55 };
            var csnExpected = 34804260;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_3453564_IsGenerated()
        {
            var totalElements = 60;
            var combination = new List<int>() { 1, 13, 33, 39, 57, 60 };
            var csnExpected = 3453564;
            var csnCalculated = CSN.Calculate(totalElements, combination);

            Assert.AreEqual(csnExpected, csnCalculated);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_24755381_IsGenerated()
        {
            var totalElements = 60;
            var combination = new List<int>() { 7, 9, 44, 51, 52, 53 };
            var csnExpected = 24755381;
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

        //------------------------------------------ Generation Combination Tests ---------------------------------------------------

        [Test]
        public void GivenFiveElementsAndCombinationSizeEqualThreeAndCSNEqualOne_WhenCombinationIsCalculated_Then_1_2_3_IsGenerated()
        {
            var totalElements = 5;
            var combinationSize = 3;
            var csn = 1;
            var combinationExpected = new List<int>() { 1, 2, 3 };
            var combinationGenerated = CSN.GenerateCombination(totalElements, combinationSize, csn);

            Assert.IsTrue(combinationGenerated.SequenceEqual(combinationExpected));
        }
    }
}
