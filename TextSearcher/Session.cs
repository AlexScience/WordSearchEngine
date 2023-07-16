namespace TextSearcher;

public sealed class Session
{
    public void Run()
    {
        var wordSearcher = new WordSearcher();
        while (true)
        {
            Console.WriteLine("Введите путь к файлу");
            var path = Console.ReadLine() ?? throw new ArgumentNullException();

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не существует, попробуйте другой путь");
                continue;
            }

            Console.WriteLine("Введите искомое слово");
            var word = Console.ReadLine() ?? throw new ArgumentNullException();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Искомое слово не должно быть пустым");
                continue;
            }

            Console.WriteLine("Искать все вхождения? (Y/N)");
            var searchAll = Console.ReadLine() == "Y";

            var results = wordSearcher.Search(path, word, searchAll).ToArray();
            if (results.Any())
            {
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Искомое слово не найдено");
            }
        }
    }
}