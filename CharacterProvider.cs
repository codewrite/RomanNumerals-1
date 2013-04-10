using System;

namespace RomanNumeral
{
    public class CharacterProvider : System.Collections.Generic.IEnumerator<char>, System.Collections.Generic.IEnumerable<char>
    {
        private string _characters;
        private int _currentPosition;

        public CharacterProvider(string characters)
        {
            _characters = characters;
            _currentPosition = -1;
        }

        public bool MoveNext()
        {
            _currentPosition++;
            return _currentPosition < _characters.Length;
        }

        public char? TryGetNextCharacter()
        {
            if (_currentPosition >= (_characters.Length - 1))
            {
                return new Nullable<char>();
            }

            return _characters[_currentPosition + 1];
        }

        public System.Collections.Generic.IEnumerator<char> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this;
        }

        public char Current
        {
            get
            {
                return _characters[_currentPosition];
            }
        }

        public void Dispose()
        {
            return;
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return _characters[_currentPosition];
            }
        }

        public void Reset()
        {
            _currentPosition = 0;
        }
    }
}
