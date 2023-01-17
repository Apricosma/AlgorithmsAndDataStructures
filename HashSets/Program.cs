// Reviewing HashSets
List<string> strings = new List<string>();

strings.Add("Hello");
strings.Add("goodbye");

bool hasGoodbye = strings.Contains("goodbye");

// create a new list for copies
List<string> allCaps = new List<string>();

foreach(string s in strings)
{
    allCaps.Add(s.ToUpper());
}

// if we know we will only have unique values
// hashsets are better because they have reduced complexity due to black magic (?)
HashSet<int> ints = new HashSet<int>();
ints.Add(1);
ints.Add(2);

bool hasTwo = ints.Contains(2);
Console.WriteLine(ints);


// dictionaries
// collection of key : value pairs
// finding keys is faster 

string testString = "The sixth sheik's sixth sheep is sick";

// count the number of each character that appears in this sentence 
// a: 1, b: 3, c: 16
//Dictionary<char, int> charCount = new Dictionary<char, int>();

//foreach(char c in testString)
//{
//    // every time we find a letter, we increment the integer
//    // value of htat letter's key
//    char letter = char.ToLower(c);

//    if (char.IsLetter(letter))
//    {

//        if (charCount.ContainsKey(letter))
//        {
//            charCount[letter]++;
//        }
//        else
//        {
//            charCount[letter] = 1;
//        }
//    }
//}

//foreach(KeyValuePair<char, int> pair in charCount)
//{
//    Console.WriteLine($"The character {pair.Key} appears {pair.Value} times");
//}

// count coin flips
List<bool> heads = new List<bool>
{
    true, false, true, true, true, false, false
};

Dictionary<string, int> flipCount = new Dictionary<string, int>();
flipCount.Add("heads", 0);
flipCount.Add("tails", 0);

foreach(bool flip in heads)
{
    if(flip)
    {
        flipCount["heads"]++;
    } else
    {
        flipCount["tails"]++;
    }
}

//charCount['a'] = 12;
//charCount['c'] = 13;

//foreach(KeyValuePair<char, int> pair in charCount)
//{
//    Console.WriteLine($"{pair.Key} : {pair.Value}");
//}


// write a dictionary that counts the number of words that start with different letters in a string
// "Mary had a little lamb"

string str = "Mary had a little lamb";
Dictionary<char, int> letterCount = new Dictionary<char, int>();
var firstLetters = str.Split(" ").Select(s => s[0]);
foreach (char c in firstLetters)
{
    char letter = char.ToLower(c);

    if (char.IsLetter(letter))
    {

        if (letterCount.ContainsKey(letter))
        {
            letterCount[letter]++;
        }
        else
        {
            letterCount[letter] = 1;
        }
    }
}

foreach (KeyValuePair<char, int> pair in letterCount)
{
    Console.WriteLine($"The character {pair.Key} appears {pair.Value} times");
}