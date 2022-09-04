using System;
using NUnit.Framework;
using Combination.Core;

namespace Combination.Tests
{
    [TestFixture]
    public class CombinationCoefficientTests
    {
        [Test]
        public void GivenTotalElementsLessThanOne_WhenCombinationCoefficientIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 0;
            var combinationSize = 1;
            var exception = Assert.Throws<ApplicationException>(() => CombinationCoefficient.Calculate(totalElements, combinationSize));

            Assert.That(exception.Message, Is.EqualTo("Total elements must be greater than 0"));
        }

        [Test]
        public void GivenCombinationSizeLessThanOne_WhenCombinationCoefficientIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 1;
            var combinationSize = 0;
            var exception = Assert.Throws<ApplicationException>(() => CombinationCoefficient.Calculate(totalElements, combinationSize));

            Assert.That(exception.Message, Is.EqualTo("Combination size must be greater than 0"));
        }

        [Test]
        public void GivenTotalElementsLessThanCombinationSize_WhenCombinationCoefficientIsCalculated_ThenAnExceptionIsGenerated()
        {
            var totalElements = 1;
            var combinationSize = 2;
            var exception = Assert.Throws<ApplicationException>(() => CombinationCoefficient.Calculate(totalElements, combinationSize));

            Assert.That(exception.Message, Is.EqualTo("Total elements must be greater than or equal combination size"));
        }

        [Test]
        public void GivenOneElementAndOneCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumberOneIsGenerated()
        {
            var totalElements = 1;
            var combinationSize = 1;
            var combinationCoefficientExpected = 1;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenTwoElementsAndOneCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumberTwoIsGenerated()
        {
            var totalElements = 2;
            var combinationSize = 1;
            var combinationCoefficientExpected = 2;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenFourElementsAndTwoCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumberSixIsGenerated()
        {
            var totalElements = 4;
            var combinationSize = 2;
            var combinationCoefficientExpected = 6;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenSixElementsAndThreeCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumberTwentyIsGenerated()
        {
            var totalElements = 6;
            var combinationSize = 3;
            var combinationCoefficientExpected = 20;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenTwentyAndFiveElementsAndThreeCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumber_2_300_IsGenerated()
        {
            var totalElements = 25;
            var combinationSize = 3;
            var combinationCoefficientExpected = 2300;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenEighteenElementsAndFourCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumber_3_060_IsGenerated()
        {
            var totalElements = 18;
            var combinationSize = 4;
            var combinationCoefficientExpected = 3060;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenFiftyTwoElementsAndFiveCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumber_2_598_960_IsGenerated()
        {
            var totalElements = 52;
            var combinationSize = 5;
            var combinationCoefficientExpected = 2_598_960;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenTwentyFiveElementsAndFifteenCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumber_3_268_760_IsGenerated()
        {
            var totalElements = 25;
            var combinationSize = 15;
            var combinationCoefficientExpected = 3_268_760;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }

        [Test]
        public void GivenSixtyElementsAndSixCombinationSize_WhenCombinationCoefficientIsCalculated_ThenNumber_50_063_860_IsGenerated()
        {
            var totalElements = 60;
            var combinationSize = 6;
            var combinationCoefficientExpected = 50_063_860;
            var combinationCoefficientCalculated = CombinationCoefficient.Calculate(totalElements, combinationSize);

            Assert.AreEqual(combinationCoefficientExpected, combinationCoefficientCalculated);
        }
    }
}
