namespace RomanNumeral
{
    public class RomanNumeralI : RomanNumeral
    {
        public RomanNumeralI()
            : base('I', 1, 'V', 'X')
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefixForPowerOf10(nextCharacter);
        }
    }
}
