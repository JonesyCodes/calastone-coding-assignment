using TextFilter.Interfaces;

namespace TextFilter.Filters
{
    public class FilterContainingCharT : IFilter
    {
        public bool Filter(string word)
        {
            return word?.ToLower().Contains('t') ?? false;
        }
    }
}
