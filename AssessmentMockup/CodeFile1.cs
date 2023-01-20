
string userInput = Console.ReadLine().ToUpper();

char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

Dictionary<char, bool> CharCheck = new Dictionary<char, bool>();

foreach(char c in alpha)
{
    CharCheck.Add(c, false);
}

foreach (char c in userInput)
{
    if (Char.IsLetter(c))
    {
        char normalized = Char.ToUpper(c);
        CharCheck[normalized] = true;
    }
}

bool hasAllEnglishCharacters = true;
List<char> missingChars = new List<char>();

foreach(KeyValuePair<char, bool> pair in CharCheck)
{
    if (!pair.Value)
    {
        missingChars.Add(pair.Key);
        hasAllEnglishCharacters = false;
    } else
    {
        hasAllEnglishCharacters = true;
    }
}

if (hasAllEnglishCharacters)
{
    Console.WriteLine("String contains all characters of the english alphabet");
}