using System;

namespace RandomClasses.Helpers
{
    public static class NumberToWordsHelper
    {
        private static readonly string[] words =
        {
        "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
        "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"
    };

        public static string NumberToWords(int number)
        {
            if (number < 0 || number >= words.Length)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            return words[number];
        }
    }
}
