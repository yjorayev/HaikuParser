using PoemValidator.Models;

namespace PoemValidator.Rules
{
    internal class LineSyllableCountRule: IRule
    {
        public LineSyllableCountRule(IEnumerable<LineSyllableCountRuleDescriptor> descriptors)
        {
            Descriptors = descriptors;
        }

        public IEnumerable<LineSyllableCountRuleDescriptor> Descriptors { get; private set; }

        public ValidationResult Validate(Poem poem)
        {
            if (poem == null)
                throw new ArgumentNullException(nameof(poem));

            foreach(LineSyllableCountRuleDescriptor descriptor in Descriptors)
            {
                var line = poem.Lines.ElementAt(descriptor.LineIndex);
                if(line.SyllableCount != descriptor.SyllableCount)
                {
                    return new ValidationResult($"line {descriptor.LineIndex + 1} has {line.SyllableCount} syllables, but should be {descriptor.SyllableCount}");
                }
            }

            return new ValidationResult();
        }
    }
}
