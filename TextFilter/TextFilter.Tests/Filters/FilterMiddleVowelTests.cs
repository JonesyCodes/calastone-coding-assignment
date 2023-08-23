using TextFilter.Filters;

namespace TextFilter.Tests.Filters
{
    [TestFixture]
    public class FilterMiddleVowelTests
    {
        [Test]
        public void Filter_returns_false_for_odd_length_where_middle_char_is_not_a_vowel()
        {
            var word = "vowel";
            var filter = new FilterMiddleVowel();

            Assert.False(filter.Filter(word));
        }

        [Test]
        public void Filter_returns_true_for_odd_length_where_middle_char_is_a_vowel()
        {
            var word = "truth";
            var filter = new FilterMiddleVowel();

            Assert.True(filter.Filter(word));
        }

        [Test]
        public void Filter_returns_false_for_even_length_where_neither_middle_char_is_a_vowel()
        {
            var word = "apples";
            var filter = new FilterMiddleVowel();

            Assert.False(filter.Filter(word));

        }

        [Test]
        [TestCase("bird")]
        [TestCase("brew")]
        [TestCase("beer")]
        public void Filter_returns_true_for_even_length_where_one_or_both_middle_chars_are_a_vowel(string word)
        {
            var filter = new FilterMiddleVowel();

            Assert.True(filter.Filter(word));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void Filter_returns_false_for_null_or_empty_string(string word)
        {
            var filter = new FilterMiddleVowel();

            Assert.False(filter.Filter(word));
        }
    }
}
