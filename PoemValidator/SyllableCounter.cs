namespace PoemValidator
{
    public static class SyllableCounter
    {
        private static readonly HashSet<char> _vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        // Unclear rules:
        // 1. What to do when more than 2 vowels come in a row? Assuming it will count as 1 syllable
        // 2. What if 'Y' comes at the end of word and after another vowel? Assuming that will count as 1. For example 'obey' is 2 syllables
        public static int CountSyllables(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            text = text.ToLower();
            int length = text.Length;
            int count = 0;


            for (var i = 0; i < length; i++)
            {
                if (_vowels.Contains(text[i]) && (i == 0 || !_vowels.Contains(text[i - 1])))
                {
                    count++;
                }
            }

            if (text[length - 1] == 'y' && (length == 1 || !_vowels.Contains(text[length - 2])))
            {
                count++;
            }

            if (text[length - 1] == 'e' && count > 1)
            {
                count--;
            }

            return count;
        }
    }
}
