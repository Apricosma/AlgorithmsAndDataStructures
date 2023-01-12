class Program
{
    static void printDuplicates(string input)
    {
        // grab input and create duplicateCharacters list 
        string str = input;
        var duplicateCharacters = new List<char>();
        int duplicateCounter = 0;

        // each character in string
        foreach (char item in str)
        {
            // duplicate counter
            int count = 0;

            // iterate the string again, comparing every letter against the
            // current iteration of letter
            // .. if f = a ... b ... c
            foreach (char chars in str)
            {
                // if match, flag count
                if (item == chars)
                {
                    count++;
                    
                }
            }

            // flagged count (item) gets added to duplicateCharacters list
            if (count > 1 && !duplicateCharacters.Contains(item))
            {
                duplicateCharacters.Add(item);
                duplicateCounter++;
            }
        }
        
        if (duplicateCounter > 0)
        {
            Console.WriteLine("[{0}]", string.Join(", ", duplicateCharacters).ToLower());
            Console.WriteLine("Instances of duplicate characters: " + duplicateCounter);
            return;
        }

        Console.WriteLine("Provided string contains no duplicate characters");
    }

    static void printUniqueWords(string input)
    {
        string str = input;
        String[] strings = str.Split(" ");
        var uniqueWords = new List<string>();
        int uniqueCounter = 0;

        foreach (string s in strings)
        {
            int count = 0;

            foreach (string words in strings)
            {
                if (s != words)
                {
                    count++;
                }
            }

            if (count > 1 && !uniqueWords.Contains(s))
            {
                uniqueWords.Add(s);
                uniqueCounter++;
            }
        }

        Console.WriteLine("Total number of unique words: " + uniqueCounter);
        Console.WriteLine("[{0}]", string.Join(", ", uniqueWords));
    }

    static void reverseString(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        Console.WriteLine(array);
    }

    static void Main(string[] args)
    {
        // reverse string
        Console.WriteLine("Input a string to reverse");
        reverseString(Console.ReadLine());

        // duplicate letters
        Console.WriteLine("Input a string to check if there are duplicates, and print all duplicates");
        string repeatCharactersString = Console.ReadLine();
        printDuplicates(repeatCharactersString);

        // all unique words
        Console.WriteLine("Input a set of words to check the total amount of unique words");
        string uniqueWordString = Console.ReadLine().ToLower();
        printUniqueWords(uniqueWordString);
    }
}