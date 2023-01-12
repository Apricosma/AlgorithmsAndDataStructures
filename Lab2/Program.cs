class Program
{
    static void repeatCharacters(string input)
    {
        string str = input;
        var duplicates = new List<char>();

        foreach (char item in str)
        {
            int count = 0;
            foreach (var chars in str)
            {
                if (item == chars)
                {
                    count++;
                }
            }

            if (count > 1 && !duplicates.Contains(item))
            {
                duplicates.Add(item);
            }
        }
        Console.WriteLine("[{0}]", string.Join(", ", duplicates).ToLower());
    }

    static void Main(string[] args)
    {
        string repeatCharactersString = "Programmatic Python";
        repeatCharacters(repeatCharactersString);
    }
}