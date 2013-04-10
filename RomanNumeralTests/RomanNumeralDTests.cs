using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralDTests
    {
        [TestCase('I')]
        [TestCase('V')]
        [TestCase('X')]
        [TestCase('L')]
        [TestCase('C')]
        [TestCase('D')]
        [TestCase('M')]
        public void IsPrefixExpectFalse(char nextCharacter)
        {
            var target = new RomanNumeralD();
            Assert.That(target.IsPrefix(nextCharacter), Is.False);
        }
    }
}
