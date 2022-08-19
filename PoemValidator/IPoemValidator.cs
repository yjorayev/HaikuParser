using PoemValidator.Models;

namespace PoemValidator
{
    public interface IPoemValidator
    {
        public ValidationResult Validate(Poem poem);
    }
}