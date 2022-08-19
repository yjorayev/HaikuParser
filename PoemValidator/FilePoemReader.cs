using PoemValidator.Models;

namespace PoemValidator
{
    public class FilePoemReader : IPoemReader
    {
        private readonly string _filePath;

        public FilePoemReader(string filePath)
        {
            _filePath = filePath;
        }

        public Poem Get()
        {
            return new Poem(File.ReadLines(_filePath));
        }
    }
}
