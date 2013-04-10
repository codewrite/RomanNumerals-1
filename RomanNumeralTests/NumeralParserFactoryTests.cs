using NUnit.Framework;
using RomanNumeral;

namespace RomanNumeralTests
{
    [TestFixture]
    public class NumeralParserFactoryTests
    {
        [Test]
        public void CreateParserExpectCorrectType()
        {
            var target = new RomanNumeralFactory();
            Assert.That(target.CreateParser('I'), Is.TypeOf<RomanNumeralI>());
            Assert.That(target.CreateParser('V'), Is.TypeOf<RomanNumeralV>());
            Assert.That(target.CreateParser('X'), Is.TypeOf<RomanNumeralX>());
            Assert.That(target.CreateParser('L'), Is.TypeOf<RomanNumeralL>());
            Assert.That(target.CreateParser('C'), Is.TypeOf<RomanNumeralC>());
            Assert.That(target.CreateParser('D'), Is.TypeOf<RomanNumeralD>());
            Assert.That(target.CreateParser('M'), Is.TypeOf<RomanNumeralM>());
        }
    }
}
