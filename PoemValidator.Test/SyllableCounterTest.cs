namespace PoemValidator.Test
{
    [TestClass]
    public class SyllableCounterTest
    {
        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void CountSyllables(string word, int syllableCount)
        {
            int count = SyllableCounter.CountSyllables(word);
            Assert.AreEqual(count, syllableCount);
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { "Madison", 3 };
            yield return new object[] { "heart", 1 };
            yield return new object[] { "your", 1 };
            yield return new object[] { "lucky", 2 };
            yield return new object[] { "code", 1 };
            yield return new object[] { "the", 1 };
            yield return new object[] { "obey", 2 };
            yield return new object[] { "Beautiful", 3 };
            yield return new object[] { "Silhouette", 2 };
            yield return new object[] { "aeoiey", 1 };
            yield return new object[] { "aeoie", 1 };
            yield return new object[] { "aeoiety", 2 };
        }
    }
}