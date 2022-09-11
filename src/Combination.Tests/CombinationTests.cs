using System;
using System.Linq;
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

        [Test]
        public void GivenCSNLessThanOne_WhenCombinationIsCalculated_ThenAnExceptionIsGenerated()
        {
            var combination = new Core.Combination(totalElements: 2, combinationSize: 2);
            var exception = Assert.Throws<ApplicationException>(() => combination.buildWith(csn: 0));

            Assert.That(exception.Message, Is.EqualTo("CSN parameter must be greater than 0"));
        }


        [Test]
        public void GivenTwoElementsAndCombinationSizeEqualTwoAndCSNEqualOne_WhenCombinationIsCalculated_Then_1_2_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2 };
            var combination = new Core.Combination(totalElements: 2, combinationSize: 2);
            combination.buildWith(csn: 1);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTwoElementsAndCombinationSizeEqualOneAndCSNEqualTwo_WhenCombinationIsCalculated_Then_2_IsGenerated()
        {
            var combinationExpected = new List<int>() { 2 };
            var combination = new Core.Combination(totalElements: 2, combinationSize: 1);
            combination.buildWith(csn: 2);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenFiveElementsAndCombinationSizeEqualThreeAndCSNEqualOne_WhenCombinationIsCalculated_Then_1_2_3_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 3 };
            var combination = new Core.Combination(totalElements: 5, combinationSize: 3);
            combination.buildWith(csn: 1);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenFiveElementsAndCombinationSizeEqualThreeAndCSNEqualThree_WhenCombinationIsCalculated_Then_1_2_5_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 5 };
            var combination = new Core.Combination(totalElements: 5, combinationSize: 3);
            combination.buildWith(csn: 3);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenEightElementsAndCombinationSizeEqualThreeAndCSNEqualThree_WhenCombinationIsCalculated_Then_1_2_5_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 5 };
            var combination = new Core.Combination(totalElements: 8, combinationSize: 3);
            combination.buildWith(csn: 3);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTenElementsAndCombinationSizeEqualFiveAndCSNEqual_189_WhenCombinationIsCalculated_Then_2_5_7_8_10_IsGenerated()
        {
            var combinationExpected = new List<int>() { 2, 5, 7, 8, 10 };
            var combination = new Core.Combination(totalElements: 10, combinationSize: 5);
            combination.buildWith(csn: 189);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenFifteenElementsAndCombinationSizeEqualFiveAndCSNEqual_1424_WhenCombinationIsCalculated_Then_2_5_7_8_10_IsGenerated()
        {
            var combinationExpected = new List<int>() { 2, 5, 7, 8, 10 };
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(csn: 1424);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenFifteenElementsAndCombinationSizeEqualFiveAndCSNEqualOne_WhenCombinationIsCalculated_Then_1_2_3_4_5_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 3, 4, 5 };
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(csn: 1);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenFifteenElementsAndCombinationSizeEqualFiveAndCSNEqual_3003_WhenCombinationIsCalculated_Then_11_12_13_14_15_IsGenerated()
        {
            var combinationExpected = new List<int>() { 11, 12, 13, 14, 15 };
            var combination = new Core.Combination(totalElements: 15, combinationSize: 5);
            combination.buildWith(csn: 3003);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenSixtyElementsAndCombinationSizeEqualSixAndCSNEqualFive_WhenCombinationIsCalculated_Then_1_2_3_4_5_10_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 3, 4, 5, 10 };
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(csn: 5);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenSixtyElementsAndCombinationSizeEqualSixAndCSNEqual_34804260_WhenCombinationIsCalculated_Then_11_15_25_38_44_55_IsGenerated()
        {
            var combinationExpected = new List<int>() { 11, 15, 25, 38, 44, 55 };
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(csn: 34804260);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenSixtyElementsAndCombinationSizeEqualSixAndCSNEqual_3453564_WhenCombinationIsCalculated_Then_01_13_33_39_57_60_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 13, 33, 39, 57, 60 };
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(csn: 3453564);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenSixtyElementsAndCombinationSizeEqualSixAndCSNEqual_24755381_WhenCombinationIsCalculated_Then_07_09_44_51_52_53_IsGenerated()
        {
            var combinationExpected = new List<int>() { 7, 9, 44, 51, 52, 53 };
            var combination = new Core.Combination(totalElements: 60, combinationSize: 6);
            combination.buildWith(csn: 24755381);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationSizeEqualFifteenAndCSNEqualOne_WhenCombinationIsCalculated_Then_01_02_03_04_05_06_07_08_09_10_11_12_13_14_15_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(csn: 1);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationSizeEqualFifteenAndCSNEqual_737432_WhenCombinationIsCalculated_Then_01_02_04_05_06_11_13_14_15_16_20_21_23_24_25_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 4, 5, 6, 11, 13, 14, 15, 16, 20, 21, 23, 24, 25 };
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(csn: 737432);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationSizeEqualFifteenAndCSNEqual_940577_WhenCombinationIsCalculated_Then_01_02_05_06_07_08_09_10_11_12_13_14_15_16_17_IsGenerated()
        {
            var combinationExpected = new List<int>() { 1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(csn: 940577);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }

        [Test]
        public void GivenTwentyFiveElementsAndCombinationSizeEqualFifteenAndCSNEqual_3268760_WhenCombinationIsCalculated_Then_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_IsGenerated()
        {
            var combinationExpected = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            var combination = new Core.Combination(totalElements: 25, combinationSize: 15);
            combination.buildWith(csn: 3268760);

            Assert.IsTrue(combination.Elements.SequenceEqual(combinationExpected));
        }
    }
}
