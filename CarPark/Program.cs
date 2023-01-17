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

    static Dictionary<string, string> getCarParkOccupancy(List<string> list) {

        Dictionary<string, string> carParkDictionary = new Dictionary<string, string>();

        foreach(string element in list)
        {
            carParkDictionary.Add(element, "0");
        }

        return carParkDictionary;
    }

    static bool checkIsEmpty(Dictionary<string, string> carPark, string key)
    {
        if (carPark[key] == "0")
        {
            return true;
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

        Dictionary<string, string> carPark = getCarParkOccupancy(carParkList);

        
        Console.WriteLine(String.Join(", ", carPark));
        Console.WriteLine("Select the lot you want: ");

        string lotSelection = Console.ReadLine().ToUpper();
        
        if (checkIsEmpty(carPark, lotSelection))
        {
            Console.WriteLine("Please input your license (six letters)");
            string license = Console.ReadLine().ToUpper();
            string keyToChange = lotSelection;
            string newKeyValue = license;
            carPark.Remove(keyToChange);
            carPark.Add(keyToChange, newKeyValue);

            Console.WriteLine(checkIsEmpty(carPark, lotSelection));
        }
    }
}