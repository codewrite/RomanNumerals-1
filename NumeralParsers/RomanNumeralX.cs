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
            if (!nextCharacter.HasValue)
            {
                return false;
            }

            if (nextCharacter == 'L')
            {
                return true;
            }

            if (nextCharacter == 'C')
            {
                return true;
            }

            return false;
        }
    }
}
