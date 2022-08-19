namespace PoemValidator.Models
{
    public class Line
    {
        public Line(string lineText)
        {
            Text = lineText;
            SetWords();
        }

        public string Text { get; private set; }

        public int SyllableCount
        {
            get
            {
                return Words.Sum(word => word.SyllableCount);
                    //.Aggregate(0, (count, next) => count + next.SyllableCount); 
            }
        }

        public IEnumerable<Word> Words { get; set; } = new List<Word>();

        private void SetWords()
        {
            Words = Text.Split().Select(word => new Word(word));
        }
    }
}
