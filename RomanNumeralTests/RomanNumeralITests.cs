using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralITests
    {
        [TestCase('V')]
        [TestCase('X')]
        public void IsPrefixExpectTrue(char nextCharacter)
        {
            var target = new RomanNumeralI();
            Assert.That(target.IsPrefix(nextCharacter), Is.True);
        }
        [TestCase('I')]
        [TestCase('L')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('M')]
        public void IsPrefixExpectFalse(char nextCharacter)
        {
            var target = new RomanNumeralI();
            Assert.That(target.IsPrefix(nextCharacter), Is.False);
        }
    }
}
