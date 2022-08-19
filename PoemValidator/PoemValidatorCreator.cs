using PoemValidator.Rules;

namespace PoemValidator
{
    public class PoemValidatorCreator
    {
        public IPoemValidator CreateHaikuValidator()
        {
            var rules = new List<IRule>
            {
                new LineCountRule(3),
                new LineSyllableCountRule(
                    new[] {
                        new LineSyllableCountRuleDescriptor(0, 5),
                        new LineSyllableCountRuleDescriptor(1, 7),
                        new LineSyllableCountRuleDescriptor(2, 5)
                    })
            };

            return new PoemValidator(rules);
        }
    }
}
