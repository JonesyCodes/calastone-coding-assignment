using TextFilter.Helpers;
using TextFilter.Services;

namespace TextFilter
{
    class Program
    {
        static void Main()
        {
            var path = FilePath.GetFilePath();

            var documentText = File.ReadAllText(path);

            var textFilter = new TextFilterService();
            
            var text = textFilter.GetFilteredText(documentText);
           
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
