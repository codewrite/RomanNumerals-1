namespace RomanNumeral
{
    public class RomanNumeralC : RomanNumeral
    {
        public RomanNumeralC()
            : base('C', 100, 'D', 'M')
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefixForPowerOf10(nextCharacter);
        }
    }
}
