using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralXTests
    {
        [TestCase('L')]
        [TestCase('C')]
        public void IsPrefixExpectTrue(char nextCharacter)
        {
            var target = new RomanNumeralX();
            Assert.That(target.IsPrefix(nextCharacter), Is.True);
        }
        [TestCase('I')]
        [TestCase('V')]
        [TestCase('X')]
        [TestCase('D')]
        [TestCase('M')]
        public void IsPrefixExpectFalse(char nextCharacter)
        {
            var target = new RomanNumeralX();
            Assert.That(target.IsPrefix(nextCharacter), Is.False);
        }
    }
}
