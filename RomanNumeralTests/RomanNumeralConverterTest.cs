using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralConverterTest
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XII", 12)]
        [TestCase("XIII", 13)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XVII", 17)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XXIV", 24)]
        [TestCase("XL", 40)]
        [TestCase("L", 50)]
        [TestCase("LX", 60)]
        [TestCase("LXIV", 64)]
        [TestCase("LXX", 70)]
        [TestCase("LXXX", 80)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        [TestCase("MDLCXVI", 1666)]
        [TestCase("MMMDCCCLXXXVIII", 3888)]
        public void GivenRomanReturnsExpectedArabic(string roman, int expectedArabic)
        {
            var actualArabic = new RomanNumeralConverter().ToArabic(roman);
            Assert.AreEqual(expectedArabic, actualArabic);
        }
    }
}
