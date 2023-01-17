using System;
using System.Text;

class Program
{
    static List<string> createCarPark(int size)
    {

        int n = size;
        List<string> carPark = new List<string>();
        int i = 0;
        while (i < n)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i < n)
                    {
                        carPark.Add(c + j.ToString());
                        i++;
                    }
                }
            }
        }

        return carPark;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input the size of the car park");
        int parkSizeInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(String.Join(", ", createCarPark(parkSizeInput)));
    }
}