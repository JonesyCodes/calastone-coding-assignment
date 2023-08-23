using System.Text;
using System.Text.RegularExpressions;
using TextFilter.Filters;
using TextFilter.Interfaces;

namespace TextFilter.Services
{
    public class TextFilterService
    {
        private readonly IFilter _middleVowel;
        private readonly IFilter _lessThanThree;
        private readonly IFilter _containsCharT;

        public TextFilterService()
        {
            _middleVowel = new FilterMiddleVowel();
            _lessThanThree = new FilterLessThanThreeChars();
            _containsCharT = new FilterContainingCharT();
        }

        public string GetFilteredText(string documentText)
        {
            // Pattern to find word boundaries
            var boundary = @"\b";
            var words = Regex.Split(documentText, boundary);

            var stringBuilder = new StringBuilder(words.Length);

            foreach (var word in words)
            {
                // Pattern to find non-word characters
                var punctuation = @"\W+";

                if (Regex.Matches(word, punctuation).Any())
                {
                    stringBuilder.Append(word);
                    continue;
                }

                if (ApplyFilters(word)) continue;

                stringBuilder.Append(word);
            }

            return stringBuilder.ToString();
        }

        private bool ApplyFilters(string word)
        {
            return _middleVowel.Filter(word) || _lessThanThree.Filter(word) || _containsCharT.Filter(word);
        }
    }
}
