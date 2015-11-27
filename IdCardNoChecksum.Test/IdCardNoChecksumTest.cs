using NUnit.Framework;
using System;

namespace IdCardNoChecksum.Test
{
    [TestFixture]
    public class IdCardNoChecksumTest
    {
        private IdCardNoChecksum checksum = new IdCardNoChecksum();

        [Test]
        public void Compute_ShouldBeValid_WhenInputValidIdCardNo()
        {
            string[] testData = { "332467260687", "209814584221", "118804799902", "608199094603", "925546789102" };
            string[] expectedResult = { "4", "9", "5", "7", "4" };
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], checksum.Compute(testData[i]));
            }
        }

        [Test]
        public void Compute_ShouldThrowArgumentException_WhenInputPassportNo()
        {
            Assert.Throws<ArgumentException>(() => checksum.Compute("TZ0167672"));
            Assert.Throws<ArgumentException>(() => checksum.Compute("TG2195407"));
        }
    }
}