using PoemValidator.Models;

namespace PoemValidator.Test
{
    [TestClass]
    public class HaikuvalidatorTest
    {
        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void HaikuValidatorTest(Poem poem, string error)
        {
            var validator = new PoemValidatorCreator().CreateHaikuValidator();
            ValidationResult result = validator.Validate(poem);
            if (string.IsNullOrEmpty(error))
            {
                Assert.IsTrue(result.IsValid);
            }
            else
            {
                Assert.AreEqual(error, result.ErrorMessage);
            }
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] {
                new Poem(new[] { "one liner" }),
                "line count is 1 but it should be 3"
            };
            yield return new object[] {
                new Poem(new[] {
                    "An old silent pond",
                    "A frog jumped into the pond",
                    "Splash! Silence again"
                }),
                "line 2 has 8 syllables, but should be 7"
            };
            yield return new object[] {
                new Poem(new[] {
                    "An old silent pond",
                    "A frog jumps into the pond",
                    "Splash! Silence again"
                }),
                ""
            };
        }
    }
}
