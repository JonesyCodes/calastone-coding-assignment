using TextFilter.Interfaces;

namespace TextFilter.Filters
{
    public class FilterLessThanThreeChars : IFilter
    {
        public bool Filter(string word)
        {
            word ??= string.Empty;
            return word.Length < 3;
        }
    }
}
