namespace RomanNumeral
{
    public class RomanNumeralX : RomanNumeral
    {
        public RomanNumeralX()
            : base('X', 10, 'L', 'C')
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefixForPowerOf10(nextCharacter);
        }
    }
}
