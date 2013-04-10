using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class CharacterProviderTests
    {
        [Test]
        public void TryGetNextWithMoreCharsExpectNextChar()
        {
            var target = new CharacterProvider("AB");
            foreach (var c in target)
            {
                Assert.That(target.TryGetNextCharacter(), Is.EqualTo('B'));
                break; //Only testing enumeration of the first character
            }
        }

        [Test]
        public void TryGetNextWithNoMoreCharsExpectNull()
        {
            var target = new CharacterProvider("A");
            foreach (var c in target)
            {
                Assert.That(target.TryGetNextCharacter(), Is.Null);
            }
        }
    }
}
