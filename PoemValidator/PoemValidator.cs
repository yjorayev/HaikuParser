using PoemValidator.Models;
using PoemValidator.Rules;

namespace PoemValidator
{
    // making this class internal ensures that it is not directly created by consumers of the library
    // PoemValidatorCreator should be used instead
    internal class PoemValidator: IPoemValidator
    {
        private readonly IEnumerable<IRule> _rules;

        public PoemValidator(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public ValidationResult Validate(Poem poem)
        {
            ValidationResult validationResult = new();

            foreach(var rule in _rules)
            {
                validationResult = rule.Validate(poem);
                if(!validationResult.IsValid)
                {
                    return validationResult;
                }
            }

            return validationResult;
        }
    }
}
