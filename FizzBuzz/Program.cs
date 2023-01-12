string fizz = "Fizz";
string buzz = "Buzz";
int sum = 0;
double total = 0;

Console.WriteLine("Please input a number");
double iterator = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i <= iterator; i++)
{
    if (i % 3 == 0 && i % 5 == 0 && i != 0)
    {
        Console.WriteLine(fizz + buzz);
    }
    else if (i % 3 == 0 && i != 0)
    {
        Console.WriteLine(fizz);
    }
    else if (i % 5 == 0 && i != 0)
    {
        Console.WriteLine(buzz);
    }
    else
    {
        Console.WriteLine(i);
        sum += i;
        total++;
    }
}

double percentage = total / iterator * 100;
Console.WriteLine("The sum of every non-fizz or buzz line is: " + sum);
Console.WriteLine("The total numbers that do not include fizzbuzz is: " + total);
Console.WriteLine("The percentage of non-fizz and non-buzz is: " + percentage + "%");