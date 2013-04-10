namespace RomanNumeral
{
    public class RomanNumeralParser
    {
        public static RomanNumeralFactory _parserFactory = new RomanNumeralFactory();

        public int ToArabic(string romanNumeral)
        {
            var characterProvider = new CharacterProvider(romanNumeral);
            var runningTotal = 0;

            foreach (var c in characterProvider)
            {
                var currentCharacter = _parserFactory.CreateParser(c);
                var nextCharacter = characterProvider.TryGetNextCharacter();
                runningTotal += currentCharacter.GetContextValue(nextCharacter);
            }

            return runningTotal;
        }
    }
}
