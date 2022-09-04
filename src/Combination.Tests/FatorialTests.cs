using System;
using NUnit.Framework;
using Combination.Core;

namespace Combination.Tests
{
    [TestFixture]
    public class FatorialTests
    {
        [Test]
        public void GivenNotExistingNumber_WhenFatorialIsCalculated_ThenAnExceptionIsGenerated()
        {
            var number = -1;

            var exception = Assert.Throws<ApplicationException>(() => Fatorial.Get(number));

            Assert.That(exception.Message, Is.EqualTo("Numero deve estar entre 0 e 171"));
        }

        [Test]
        public void GivenNumberZero_WhenFatorialIsCalculated_ThenNumberOneIsGenerated()
        {
            var number = 0;
            var fatorialExpected = 1;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }

        [Test]
        public void GivenNumberOne_WhenFatorialIsCalculated_ThenNumberOneIsGenerated()
        {
            var number = 1;
            var fatorialExpected = 1;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }

        [Test]
        public void GivenNumberTwo_WhenFatorialIsCalculated_ThenNumberTwoIsGenerated()
        {
            var number = 2;
            var fatorialExpected = 2;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }

        [Test]
        public void GivenNumberThree_WhenFatorialIsCalculated_ThenNumberSixIsGenerated()
        {
            var number = 3;
            var fatorialExpected = 6;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }

        [Test]
        public void GivenNumberTen_WhenFatorialIsCalculated_ThenNumber_3_628_800_IsGenerated()
        {
            var number = 10;
            var fatorialExpected = 3_628_800;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }

        [Test]
        public void GivenNumberFifteen_WhenFatorialIsCalculated_ThenNumber_1_307_674_368_000_IsGenerated()
        {
            var number = 15;
            var fatorialExpected = 1_307_674_368_000;
            var fatorialCalculated = Fatorial.Get(number);

            Assert.AreEqual(fatorialExpected, fatorialCalculated);
        }
    }
}
