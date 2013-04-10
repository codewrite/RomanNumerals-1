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
    }
}
