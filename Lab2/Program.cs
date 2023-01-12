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

    static void Main(string[] args)
    {
        Console.WriteLine("Input a string to check if there are duplicates, and print all duplicates");
        string repeatCharactersString = Console.ReadLine();
        printDuplicates(repeatCharactersString);
    }
}