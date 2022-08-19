using PoemValidator;

string path = ".\\Poem1.txt";
try
{
    IPoemReader poemRepository = new FilePoemReader(path);
    var poem = poemRepository.Get();
    IPoemValidator poemValidator = new PoemValidatorCreator().CreateHaikuValidator();

    var validationResult = poemValidator.Validate(poem);
    if (validationResult.IsValid)
    {
        Console.WriteLine("Valid haiku");
    }
    else
    {
        Console.WriteLine($"Not a haiku poem because {validationResult.ErrorMessage}.");
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}