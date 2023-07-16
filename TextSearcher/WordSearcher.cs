namespace TextSearcher;

public sealed class WordSearcher
{
    public IEnumerable<string> Search(string path, string word, bool searchAll)
    {
        List<string> results = new ();
        var counter = 0;
        
        foreach (var line in File.ReadLines(path))
        {
            counter++;

            var words = line.Split(" ");
            if (words.Contains(word))
            {
                results.Add($"{counter}: {line}");
                if (!searchAll)
                {
                    break;
                }
            }
        }

        return results;
    }
}