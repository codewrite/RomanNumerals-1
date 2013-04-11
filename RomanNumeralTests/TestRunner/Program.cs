using RomanNumeralTests;

namespace TestRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new NumeralValidatorTests().IsValidWithValidRepeatedCharExpectValid("XXXIX");
        }
    }
}
