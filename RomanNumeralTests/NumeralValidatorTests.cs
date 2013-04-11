using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class NumeralValidatorTests
    {
        private RomanNumeralValidator _target;

        [TestFixtureSetUp]
        public void Setup()
        {
            _target = new RomanNumeralValidator();
        }

        [TestCase("I")]
        [TestCase("V")]
        [TestCase("X")]
        [TestCase("L")]
        [TestCase("C")]
        [TestCase("D")]
        [TestCase("M")]
        public void IsValidWithSingleValidCharExpectValid(string input)
        {
            Assert.That(_target.IsValid(input));
        }

        [TestCase("II")]
        [TestCase("III")]
        [TestCase("XX")]
        [TestCase("XXX")]
        [TestCase("CC")]
        [TestCase("CCC")]
        [TestCase("MM")]
        [TestCase("MMM")]
        [TestCase("XXXIX")]
        public void IsValidWithValidRepeatedCharExpectValid(string input)
        {
            Assert.That(_target.IsValid(input));
        }

        [TestCase("VIV")]
        [TestCase("LCL")]
        [TestCase("MDD")]
        public void IsValidWithInvalidRepeatedCharsExpectInvalid(string input)
        {
            Assert.That(_target.IsValid(input), Is.False);
        }

        [TestCase("IIII")]
        [TestCase("XXXX")]
        [TestCase("CCCC")]
        [TestCase("MMMMM")]
        public void IsValidWithTooManyRepeatableCharsExpectInvalid(string input)
        {
            Assert.That(_target.IsValid(input), Is.False);
        }

        [TestCase("A")]
        [TestCase("K")]
        [TestCase("1")]
        public void IsValidWithInvalidCharsExpectInvalid(string input)
        {
            Assert.That(_target.IsValid(input), Is.False);
        }

        [TestCase("IIV")]
        [TestCase("IIX")]
        [TestCase("XXC")]
        [TestCase("XXL")]
        [TestCase("CCM")]
        public void IsValidWithInvalidPrefixPatternExpectInvalid(string input)
        {
            Assert.That(_target.IsValid(input), Is.False);
        }

        //TODO:MMJ Next!
        //[TestCase("ID")]
        //public void IsValidWithInvalidPrefixExpectInvalid(string input)
        //{
        //    Assert.That(_target.IsValid(input), Is.False);
        //}
    }
}
