using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class RomanNumeralVTests
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
            var target = new RomanNumeralV();
            Assert.That(target.IsPrefix(nextCharacter), Is.False);
        }

    }
}
