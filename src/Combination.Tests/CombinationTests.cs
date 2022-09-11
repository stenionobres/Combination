using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Combination.Tests
{
    [TestFixture]
    public class CombinationTests
    {
        [Test]
        public void GivenANullElements_WhenCombinationIsBuilt_ThenAnExceptionIsGenerated()
        {
            var combination = new Core.Combination(totalElements: 2, combinationSize: 2);
            var exception = Assert.Throws<ApplicationException>(() => combination.buildWith(elements: null));

            Assert.That(exception.Message, Is.EqualTo("Elements parameter cannot be null"));
        }

        [Test]
        public void GivenElementsSizeDifferentOfCombinationSize_WhenCombinationIsBuilt_ThenAnExceptionIsGenerated()
        {
            var combination = new Core.Combination(totalElements: 2, combinationSize: 2);
            var exception = Assert.Throws<ApplicationException>(() => combination.buildWith(elements: new List<int> { 1 }));

            Assert.That(exception.Message, Is.EqualTo("Elements parameter must be the same size of CombinationSize parameter"));
        }

        [Test]
        public void GivenTotalElementsLessThanCombinationSize_WhenCSNIsCalculated_ThenNumberZeroIsGenerated()
        {
            var csnExpected = 0;
            var combination = new Core.Combination(totalElements: 0, combinationSize: 2);
            combination.buildWith(elements: new List<int> { 1, 2 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenCombinationSizeGreaterThanTotalElements_WhenCSNIsCalculated_ThenNumberZeroIsGenerated()
        {
            var csnExpected = 0;
            var combination = new Core.Combination(totalElements: 2, combinationSize: 3);
            combination.buildWith(elements: new List<int> { 1, 2, 3 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwoElementsAndCombinationWithTwoNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var csnExpected = 1;
            var combination = new Core.Combination(totalElements: 2, combinationSize: 2);
            combination.buildWith(elements: new List<int> { 1, 2 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwoElementsAndCombinationWithOneNumber_WhenCSNIsCalculated_ThenNumberTwoIsGenerated()
        {
            var csnExpected = 2;
            var combination = new Core.Combination(totalElements: 2, combinationSize: 1);
            combination.buildWith(elements: new List<int> { 2 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var csnExpected = 1;
            var combination = new Core.Combination(totalElements: 5, combinationSize: 3);
            combination.buildWith(elements: new List<int> { 1, 2, 3 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbersNotOrdered_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var csnExpected = 1;
            var combination = new Core.Combination(totalElements: 5, combinationSize: 3);
            combination.buildWith(elements: new List<int> { 1, 3, 2 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFiveElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberThreeIsGenerated()
        {
            var csnExpected = 3;
            var combination = new Core.Combination(totalElements: 5, combinationSize: 3);
            combination.buildWith(elements: new List<int> { 1, 2, 5 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenEigthElementsAndCombinationWithThreeNumbers_WhenCSNIsCalculated_ThenNumberThreeIsGenerated()
        {
            var csnExpected = 3;
            var combination = new Core.Combination(totalElements: 8, combinationSize: 3);
            combination.buildWith(elements: new List<int> { 1, 2, 5 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumberOneHundredEightyNineIsGenerated()
        {
            var csnExpected = 189;
            var combination = new Core.Combination(totalElements: 10, combinationSize: 5);
            combination.buildWith(elements: new List<int> { 2, 5, 7, 8, 10 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumber_1424_IsGenerated()
        {
            var csnExpected = 1424;
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(elements: new List<int> { 2, 5, 7, 8, 10 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbersNotOrdered_WhenCSNIsCalculated_ThenNumber_1424_IsGenerated()
        {
            var csnExpected = 1424;
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(elements: new List<int> { 2, 7, 5, 10, 8 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var csnExpected = 1;
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(elements: new List<int> { 1, 2, 3, 4, 5 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenFifteenElementsAndCombinationWithFiveNumbers_WhenCSNIsCalculated_ThenNumber_3003_IsGenerated()
        {
            var csnExpected = 3003;
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(elements: new List<int> { 11, 12, 13, 14, 15 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumberFiveIsGenerated()
        {
            var csnExpected = 5;
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(elements: new List<int> { 1, 2, 3, 4, 5, 10 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_34804260_IsGenerated()
        {
            var csnExpected = 34804260;
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(elements: new List<int> { 11, 15, 25, 38, 44, 55 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_3453564_IsGenerated()
        {
            var csnExpected = 3453564;
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(elements: new List<int> { 1, 13, 33, 39, 57, 60 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenSixtyElementsAndCombinationWithSixNumbers_WhenCSNIsCalculated_ThenNumber_24755381_IsGenerated()
        {
            var csnExpected = 24755381;
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(elements: new List<int> { 7, 9, 44, 51, 52, 53 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumberOneIsGenerated()
        {
            var csnExpected = 1;
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(elements: new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_737432_IsGenerated()
        {
            var csnExpected = 737432;
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(elements: new List<int> { 1, 2, 4, 5, 6, 11, 13, 14, 15, 16, 20, 21, 23, 24, 25 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_940577_IsGenerated()
        {
            var csnExpected = 940577;
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(elements: new List<int> { 1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationWithFifteenNumbers_WhenCSNIsCalculated_ThenNumber_3268760_IsGenerated()
        {
            var csnExpected = 3268760;
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(elements: new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });

            Assert.AreEqual(csnExpected, combination.CSN);
        }
    }
}
