namespace PoemValidator.Rules
{
    internal class LineSyllableCountRuleDescriptor
    {
        public LineSyllableCountRuleDescriptor(int lineIndex, int syllableCount)
        {
            LineIndex = lineIndex;
            SyllableCount = syllableCount;
        }

        public int LineIndex { get; private set; }

        public int SyllableCount { get; private set; }
    }
}
