namespace TextFilter.Helpers
{
    internal static class FilePath
    {
        public static string GetFilePath()
        {
            Console.WriteLine("Please enter the full path to your text file:");
            var path = Console.ReadLine().Trim();

            while (!File.Exists(path))
            {
                Console.WriteLine($"Invalid path: {path}\nPlease enter a new path or enter 'X' to exit:");
                path = Console.ReadLine();

                if (path?.ToLower() == "x") Environment.Exit(0);
            }

            return path;
        }
    }
}
