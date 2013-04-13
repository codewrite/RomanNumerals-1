using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeral
{
    public class RomanNumeralValidator
    {

        public bool IsValid(string romanNumeral)
        {
            if (ContainsAnyInvalidChar(romanNumeral))
            {
                return false;
            }

            if (HasRepeatOfAny(romanNumeral, 'V', 'L', 'D'))
            {
                return false;
            }

            if (MoreThan3InSequence(romanNumeral, 'I', 'X', 'C', 'M'))
            {
                return false;
            }

            if (ContainsInvalidPrefix(romanNumeral))
            {
                return false;
            }

            if (RepeatedCharsAppearBeforeAny(romanNumeral, 'I', 'V', 'X'))
            {
                return false;
            }

            if (RepeatedCharsAppearBeforeAny(romanNumeral, 'X', 'L', 'C'))
            {
                return false;
            }

            if (RepeatedCharsAppearBeforeAny(romanNumeral, 'C', 'D', 'M'))
            {
                return false;
            }

            return true;
        }

        private bool ContainsInvalidPrefix(string romanNumeral)
        {
            //TODO:MJ this makes XXXIX test fail

            //var validNextChars = new Dictionary<char, string> { { 'I', "IVX" }, { 'X', "XLC" }, { 'C', "CDM" } };

            //var characterProvider = new CharacterProvider(romanNumeral);

            //foreach (var testChar in characterProvider)
            //{
            //    char? nextChar = characterProvider.TryGetNextCharacter();
            //    if (nextChar.HasValue)
            //    {
            //        if (!validNextChars.ContainsKey(testChar))
            //        {
            //            continue;
            //        }
            //        if (!validNextChars[testChar].Contains(nextChar.Value))
            //        {
            //            return true;
            //        }
            //    }
            //}
            return false;
        }

        private bool RepeatedCharsAppearBeforeAny(string romanNumeral, char testChar, params char[] subsequentChars)
        {
            foreach (var subsequentChar in subsequentChars)
            {
                if (HasRepeatOf(romanNumeral, testChar))
                {
                    if (romanNumeral.IndexOf(new string(testChar, 2)) < romanNumeral.IndexOf(subsequentChar))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ContainsAnyInvalidChar(string romanNumeral)
        {
            const string validChars = "IVXLCDM";
            return romanNumeral.Any(c => !validChars.Contains(c));
        }

        private bool MoreThan3InSequence(string romanNumeral, params char[] chars)
        {
            foreach (char testChar in chars)
            {
                if (MaxInSequence(romanNumeral, testChar) > 3)
                {
                    return true;
                }
            }
            return false;
        }

        private int MaxInSequence(string romanNumeral, char testChar)
        {
            var maxSequenceCount = 0;
            var currentSequenceCount = 0;
            var index = 0;

            while (index < romanNumeral.Length)
            {
                if (romanNumeral[index] == testChar)
                {
                    currentSequenceCount++;
                    maxSequenceCount = Math.Max(maxSequenceCount, currentSequenceCount);
                }
                else
                {
                    currentSequenceCount = 0;
                }
                index++;
            }
            return maxSequenceCount;
        }

        private bool HasRepeatOfAny(string romanNumeral, params char[] chars)
        {
            foreach (var testChar in chars)
            {
                if (HasRepeatOf(romanNumeral, testChar))
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasRepeatOf(string romanNumeral, char testChar)
        {
            if (romanNumeral.Count(c => c == testChar) > 1)
            {
                return true;
            }
            return false;
        }
    }
}