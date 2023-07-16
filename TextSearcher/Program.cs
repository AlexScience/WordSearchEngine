// See https://aka.ms/new-console-template for more information

//../../../../text.txt

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

    var counter = 0;
    var found = false;
    foreach (var line in File.ReadLines(path))
    {
        counter++;
        
        var words = line.Split(" ");
        if (words.Contains(word))
        {
            found = true;
            Console.WriteLine($"{counter}: {line}");
            if (!searchAll)
            {
                break;
            }
        }
    }

    if (!found)
    {
        Console.WriteLine("Искомое слово не найдено");
    }
}