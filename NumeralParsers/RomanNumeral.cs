namespace RomanNumeral
{
    public abstract class RomanNumeral
    {
        protected RomanNumeral(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public int GetContextValue(char? nextCharacter)
        {
            return IsPrefix(nextCharacter) ? -Value : Value;
        }

        public virtual bool IsPrefix(char? nextCharacter)
        {
            return false;
        }

        public virtual bool IsPrefix(char? nextCharacter, char prefixableChar1, char prefixableChar2)
        {
            if (!nextCharacter.HasValue)
            {
                return false;
            }

            if (nextCharacter == prefixableChar1)
            {
                return true;
            }

            if (nextCharacter == prefixableChar2)
            {
                return true;
            }

            return false;
        }
    }
}
