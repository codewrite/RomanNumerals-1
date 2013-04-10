using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralCTests
    {
        [TestCase('D')]
        [TestCase('M')]
        public void IsPrefixExpectTrue(char nextCharacter)
        {
            var target = new RomanNumeralC();
            Assert.That(target.IsPrefix(nextCharacter), Is.True);
        }
        [TestCase('I')]
        [TestCase('V')]
        [TestCase('X')]
        [TestCase('L')]
        [TestCase('C')]
        public void IsPrefixExpectFalse(char nextCharacter)
        {
            var target = new RomanNumeralC();
            Assert.That(target.IsPrefix(nextCharacter), Is.False);
        }
    }
}
