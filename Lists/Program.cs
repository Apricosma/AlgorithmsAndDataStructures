// create a program that prompts users for positive numbers until they enter
// a number that is odd

// once that is done, print all of the numbers comma separated, and print the
// sum of all hose numbers

// if value is positive
// if value is divisible by two


Console.WriteLine("Enter a number");
int intInput = Int32.Parse(Console.ReadLine());
List<int> evenValues = new List<int>();

while (intInput <= 0)
{
    Console.WriteLine("Please enter a positive value");
    intInput = Int32.Parse(Console.ReadLine());
}

do
{
    if (intInput <= 0)
    {
        Console.WriteLine("Please enter a positive value");
    }
    else
    {
        evenValues.Add(intInput);
        Console.WriteLine("Enter another number: ");
    }

    intInput = Int32.Parse(Console.ReadLine());
} while (intInput % 2 == 0);


// hashsets
// work almost identically to lists
// a hashset is a SET, there cannot be duplicates in a set

HashSet<int> intHash = new HashSet<int>();
intHash.Add(1);
intHash.Add(2);
intHash.Add(1);

Console.WriteLine(String.Join(", ", intHash));