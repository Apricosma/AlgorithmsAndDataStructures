using System;

class Program
{
    static int GetHighestValueInList(List<int> inputList)
    {
        // O(n) 
        return inputList.Max();
    }

    //static List<int> MaxNumbersInLists(List<List<int>> inputList)
    //{
        
    //}

    static void Main(string[] args)
    {
        List<int> testList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine(GetHighestValueInList(testList));
    }
}