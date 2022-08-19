using PoemValidator.Models;

namespace PoemValidator.Rules
{
    internal class LineCountRule : IRule
    {
        public LineCountRule(int lineCount)
        {
            ExpectedLineCount = lineCount;
        }

        public int ExpectedLineCount { get; private set; }

        public ValidationResult Validate(Poem poem)
        {
            if(poem == null)
                throw new ArgumentNullException(nameof(poem));

            var lineCount = poem.Lines.Count();
            if (lineCount == ExpectedLineCount)
            {
                return new ValidationResult();
            }

            return new ValidationResult($"line count is {lineCount} but it should be {ExpectedLineCount}");
        }
    }
}
