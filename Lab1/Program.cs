// get number of words
Console.WriteLine("Please enter a number: ");
string result = Console.ReadLine();
int numberOfWords;
bool isNumber = int.TryParse(result, out numberOfWords);
// while input is not a number - repeat
while (!isNumber)
{
    Console.WriteLine("Please enter a number: ");
    result = Console.ReadLine();
    isNumber = int.TryParse(result, out numberOfWords);
}

// initialize array with n words
string[] stringArray = new string[numberOfWords];
Console.WriteLine("Please enter " + numberOfWords + " words\nInput is not case-sensitive");
Console.WriteLine(" ");

// pushes n words to array
for (int i = 0; i < stringArray.Length; i++)
{
    stringArray[i] = Console.ReadLine().ToLower().Trim();
    if (stringArray[i].Any(Char.IsWhiteSpace))
    {
        Console.WriteLine("Do not use spaces in words, enter previous word again");
        stringArray[i] = Console.ReadLine().ToLower().Trim();
    }
}
Console.WriteLine(" ");

// lists all current words
Console.WriteLine("Your list of words is: ");
for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine(stringArray[i]);
}
Console.WriteLine(" ");

// sets the search term
Console.WriteLine("Please enter a character to search: ");
char searchCharacter = Char.ToLower(Console.ReadKey().KeyChar);

while (!Char.IsLetter(searchCharacter))
{
    Console.WriteLine("Please input a LETTER");
    searchCharacter = Char.ToLower(Console.ReadKey().KeyChar);
}
Console.WriteLine(" ");

// concatenates the array of strings into a single string for iteration
string concatString = string.Join(", ", stringArray);
int count = 0;

foreach (char n in concatString)
{
    if (n == searchCharacter) count++;
}
Console.WriteLine("Your character " + "'" + searchCharacter + "'" + " shows up " + count + " times ");
Console.WriteLine(" ");

double lengthOfString = concatString.Length;
double percentage = Convert.ToDouble(count) / lengthOfString;

if (percentage > 0.25)
{
    Console.WriteLine(searchCharacter + " Shows up more than 25% of the total number of characters");
}