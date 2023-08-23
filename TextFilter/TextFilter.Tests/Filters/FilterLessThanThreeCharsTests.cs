using TextFilter.Filters;

namespace TextFilter.Tests.Filters
{
    [TestFixture]
    internal class FilterLessThanThreeCharsTests
    {
        [Test]
        public void Filter_Returns_False_For_String_Length_Greater_Than_Three()
        {
            var word = "TestString";
            var filter = new FilterLessThanThreeChars();

            Assert.False(filter.Filter(word));
        }

        [Test]
        public void Filter_returns_True_for_String_Length_Less_Than_Three()
        {
            var word = "ab";
            var filter = new FilterLessThanThreeChars();

            Assert.True(filter.Filter(word));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Filter_returns_true_for_null_or_empty_string(string word)
        {
            var filter = new FilterLessThanThreeChars();
            Assert.True(filter.Filter(word));
        }
    }
}
