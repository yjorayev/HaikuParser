namespace PoemValidator.Models
{
    public class Word
    {
        public Word(string wordText)
        {
            Text = wordText.Trim();
            SyllableCount = SyllableCounter.CountSyllables(Text);
        }

        public string Text { get; private set; }

        public int SyllableCount { get; }
    }
}