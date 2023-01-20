using System;
using System.Text;
using System.Text.RegularExpressions;

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
        try
        {
            if (carPark[key] == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        } catch (KeyNotFoundException ex)
        {
            return false;
        }
    }

    static void printLot(Dictionary<string, string> lot) {
        StringBuilder sb = new StringBuilder();
        int counter = 0;

        foreach(var element in lot)
        {
            sb.Append($"{element.Key.PadRight(1)}:{element.Value.PadRight(6)} | ");
            counter++;
            if (counter % 10 == 0)
            {
                sb.Append(Environment.NewLine);
            }
        }
        Console.WriteLine(sb.ToString());
        
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Input the size of the car park (Max 260)");
        int parkSizeInput = Convert.ToInt32(Console.ReadLine());
        
        List<string> carParkList = createCarPark(parkSizeInput);

        Dictionary<string, string> carPark = getCarParkOccupancy(carParkList);


        ConsoleKey quit = ConsoleKey.Q;
        while (true)
        {
            printLot(carPark);
            Console.WriteLine("Select the lot you want: (Q to quit)");
            string lotSelection;
            while (true)
            {
                lotSelection = Console.ReadLine().ToUpper();
                if (Regex.IsMatch(lotSelection, @"[A-Z][0-9]") || lotSelection == quit.ToString())
                {
                    break;
                } else
                {
                    Console.WriteLine("Please input correct format (eg. C7)");
                }
            }

            if (lotSelection == quit.ToString())
            {
                break;
            } else
            {
                if (checkIsEmpty(carPark, lotSelection))
                {
                    Console.WriteLine("Please input your license (six letters)");
                    string license = Console.ReadLine().ToUpper();
                    string keyToChange = lotSelection;
                    string newKeyValue = license;
                    carPark.Remove(keyToChange);
                    carPark.Add(keyToChange, newKeyValue);
                }
                else
                {
                    Console.WriteLine("Lot not found or lot is occupied, please try again (submit any key to continue)");
                    lotSelection = Console.ReadLine().ToUpper();
                }
            }
        }
    }
}