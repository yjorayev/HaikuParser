namespace PoemValidator.Models
{
    public class Poem
    {
        public Poem(IEnumerable<string> lines)
        {
            Lines = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => new Line(line));
        }

        public IEnumerable<Line> Lines { get; set; } = new List<Line>();
    }
}
