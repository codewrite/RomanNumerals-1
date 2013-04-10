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
            if (!nextCharacter.HasValue)
            {
                return false;
            }

            if (nextCharacter == 'V')
            {
                return true;
            }

            if (nextCharacter == 'X')
            {
                return true;
            }

            return false;
        }
    }
}
