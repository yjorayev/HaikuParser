using PoemValidator.Models;
using System.ComponentModel.DataAnnotations;

namespace PoemValidator.Rules
{
    public interface IRule
    {
        ValidationResult Validate(Poem poem);
    }
}