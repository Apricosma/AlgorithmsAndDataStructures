using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;

        while(programRunning)
        {
            Console.WriteLine("1. Check alphabetical characters 2. Check longest prefix 3. Quit");
            int navigationInput = Int32.Parse(Console.ReadLine());

            // alphabet
            if (navigationInput == 1) {

                #region
                Console.WriteLine("Enter a string of letters to check if it contains every letter in the alphabet");
                string stringInput = Console.ReadLine().ToUpper();

                if (!Regex.IsMatch(stringInput, @"[A-Za-z]+$"))
                {
                    Console.WriteLine("Please input only letters");
                    stringInput = Console.ReadLine().ToUpper();
                }

                char[] letters = stringInput.ToCharArray();
                HashSet<char> AlphabetHash = new HashSet<char>();
                HashSet<char> FullAlphabet = new HashSet<char>();

                for (char c = 'A'; c <= 'Z'; c++)
                {
                    FullAlphabet.Add(c);
                }

                foreach (char letter in letters)
                {
                    AlphabetHash.Add(letter);
                }

                if (AlphabetHash.Count < 26)
                {
                    Console.WriteLine("Your input does not contain every letter");
                }
                #endregion
            } else if(navigationInput== 2)
            {
                // longest prefix
                #region
                Console.WriteLine("Input a comma separated list of words (e.g. daisy, dairy, darts, dais, dame).");
                string userWords = Console.ReadLine().ToUpper();

                string[] stringArray = userWords.Replace(" ", "").Split(',');

                string result = stringArray[0];
                int longestPrefixLength = result.Length;

                foreach (string word in stringArray)
                {
                    int i = 0;
                    foreach (char c in word)
                    {
                        if (i >= longestPrefixLength || result[i] != c)
                        {
                            break;
                        }
                        i++;
                    }
                    longestPrefixLength = Math.Min(longestPrefixLength, i);
                }

                Console.WriteLine(result.Substring(0, longestPrefixLength));
                #endregion
            } else if (navigationInput== 3)
            {
                break;
            }
        }
    }
}