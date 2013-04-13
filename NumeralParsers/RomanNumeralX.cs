namespace RomanNumeral
{
    public class RomanNumeralX : RomanNumeral
    {
        public RomanNumeralX()
            : base(10)
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefix(nextCharacter, 'L', 'C');
        }
    }
}
