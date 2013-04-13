namespace RomanNumeral
{
    public class RomanNumeralI : RomanNumeral
    {
        public RomanNumeralI()
            : base(1)
        {
        }

        public override bool IsPrefix(char? nextCharacter)
        {
            return IsPrefix(nextCharacter, 'V', 'X');
        }
    }
}
