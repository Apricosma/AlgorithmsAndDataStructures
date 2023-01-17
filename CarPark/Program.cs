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

    static Dictionary<string, int> getCarParkOccupancy(List<string> list) {

        Dictionary<string, int> carParkDictionary = new Dictionary<string, int>();

        foreach(string element in list)
        {
            carParkDictionary.Add(element, 0);
        }

        return carParkDictionary;
    }

    static bool checkIsEmpty(Dictionary<string, int> carPark, string key)
    {
        int value;
        if(carPark.TryGetValue(key, out value))
        {
            return value == 0;
        } else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Input the size of the car park");
        int parkSizeInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(String.Join(", ", createCarPark(parkSizeInput)));
        List<string> carParkList = createCarPark(parkSizeInput);

        Dictionary<string, int> carPark = getCarParkOccupancy(carParkList);

        
        Console.WriteLine(String.Join(", ", carPark));
        Console.WriteLine("Select the lot you want");

        Console.WriteLine(checkIsEmpty(carPark, Console.ReadLine()));
    }
}