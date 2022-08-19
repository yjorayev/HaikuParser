namespace PoemValidator
{
    public class ValidationResult
    {
        public ValidationResult() { }

        public ValidationResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public bool IsValid
        {
            get
            {
                return string.IsNullOrWhiteSpace(ErrorMessage);
            }
        }

        public string? ErrorMessage { get; private set; }
    }
}
