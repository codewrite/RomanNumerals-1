namespace RomanNumeral
{
    public abstract class RomanNumeral
    {
        protected RomanNumeral(char symbol, int value)
        {
            Symbol = symbol;
            Value = value;
            PrefixableChar1 = null;
            PrefixableChar2 = null;
        }

        protected RomanNumeral(char symbol, int value, char prefixableChar1, char prefixableChar2)
        {
            Symbol = symbol;
            Value = value;
            PrefixableChar1 = prefixableChar1;
            PrefixableChar2 = prefixableChar2;
        }

        public char Symbol { get; private set; }
        public int Value { get; private set; }
        public char? PrefixableChar1 { get; private set; }
        public char? PrefixableChar2 { get; private set; }

        public int GetContextValue(char? nextCharacter)
        {
            return IsPrefix(nextCharacter) ? -Value : Value;
        }

        public virtual bool IsPrefix(char? nextCharacter)
        {
            return false;
        }

        //TODO: I think this should be refactored as a new class for I, X and C
        public virtual bool IsPrefixForPowerOf10(char? nextCharacter)
        {
            if (!nextCharacter.HasValue)
            {
                return false;
            }

            if (nextCharacter == PrefixableChar1)
            {
                return true;
            }

            if (nextCharacter == PrefixableChar2)
            {
                return true;
            }

            return false;
        }
    }
}
