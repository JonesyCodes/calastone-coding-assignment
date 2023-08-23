using TextFilter.Interfaces;

namespace TextFilter.Filters
{
    public class FilterMiddleVowel : IFilter
    {
        private readonly List<char> _vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        public bool Filter(string word)
        {
            word = word?.ToLower() ?? string.Empty;
            var length = word.Length;
            var index = length / 2;

            switch (length) {
                case 0:
                    return false;
                case 1:
                    return IsVowel(word[0]);
                default:
                    return word.Length % 2 == 0
                        ? IsVowel(word[index]) || IsVowel(word[index - 1])
                        : IsVowel(word[index]);
            }

        }

        private bool IsVowel(char center)
        {
            return _vowels.Contains(center);
        }
    }
}
