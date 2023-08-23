using TextFilter.Filters;

namespace TextFilter.Tests.Filters
{
    [TestFixture]
    internal class FilterContainingCharTTests
    {
        [Test]
        public void Filter_returns_false_if_word_does_not_contain_char_t()
        {
            var word = "safe";
            var filter = new FilterContainingCharT();

            Assert.False(filter.Filter(word));
        }

        [Test]
        [TestCase("True")]
        [TestCase("true")]
        public void Filter_returns_true_if_filter_does_contain_t_or_T(string word)
        {
            var filter = new FilterContainingCharT();

            Assert.True(filter.Filter(word));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Filter_returns_false_if_null_or_empty(string word)
        {
            var filter = new FilterContainingCharT();

            Assert.False(filter.Filter(word));
        }
    }
}
