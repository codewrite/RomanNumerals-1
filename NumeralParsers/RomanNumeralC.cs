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
            if (!nextCharacter.HasValue)
            {
                return false;
            }

            if (nextCharacter == 'D')
            {
                return true;
            }

            if (nextCharacter == 'M')
            {
                return true;
            }

            return false;
        }
    }
}
