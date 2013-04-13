namespace RomanNumeral
{
    public class RomanNumeralC : RomanNumeral
    {
        public RomanNumeralC()
            : base(100)
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefix(nextCharacter, 'D', 'M');
        }
    }
}
