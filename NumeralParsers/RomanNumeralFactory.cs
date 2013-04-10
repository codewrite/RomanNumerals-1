namespace RomanNumeral
{
    public class RomanNumeralFactory
    {
        public RomanNumeral CreateParser(char character)
        {
            switch (character)
            {
                case 'I':
                    return new RomanNumeralI();
                case 'V':
                    return new RomanNumeralV();
                case 'X':
                    return new RomanNumeralX();
                case 'L':
                    return new RomanNumeralL();
                case 'C':
                    return new RomanNumeralC();
                case 'D':
                    return new RomanNumeralD();
                case 'M':
                    return new RomanNumeralM();
            }
            return null;
        }
    }
}
