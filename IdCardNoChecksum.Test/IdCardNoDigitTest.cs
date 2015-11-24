using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdCardNoChecksum.Test
{
    [TestFixture]
    class IdCardNoDigitTest
    {
        [Test]
        public void FirstDigit_ShouldBe13_WhenInput1()
        {
            Assert.AreEqual(13, IdCardNoDigit.Calculate(1, 1));
        }

        [Test]
        public void FirstDigit_ShouldBe65_WhenInput5()
        {
            Assert.AreEqual(65, IdCardNoDigit.Calculate(5, 1));
        }

        [Test]
        public void SecondDigit_ShouldBe12_WhenInput1()
        {
            Assert.AreEqual(12, IdCardNoDigit.Calculate(1, 2));
        }

        [Test]
        public void SecondDigit_ShouldBe72_WhenInput6()
        {
            Assert.AreEqual(72, IdCardNoDigit.Calculate(6, 2));
        }

        [Test]
        public void ThirdDigit_ShouldBe11_WhenInput1()
        {
            Assert.AreEqual(11, IdCardNoDigit.Calculate(1, 3));
        }

        [Test]
        public void FifthDigit_ShouldBe45_WhenInput5()
        {
            Assert.AreEqual(45, IdCardNoDigit.Calculate(5, 5));
        }

        [Test]
        public void TwelthDigit_ShouldBe6_WhenInput3()
        {
            Assert.AreEqual(6, IdCardNoDigit.Calculate(3, 12));
        }
    }
}
