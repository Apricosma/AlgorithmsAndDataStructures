using System;
using System.Linq.Expressions;

class Program
{
    static int GetHighestValueInList(List<int> inputList)
    {
        // O(n) 
        return inputList.Max();
    }

    static List<int> MaxNumbersInLists(List<List<int>> inputList)
    {
        List<int> maxIntList = new List<int>();

        foreach(List<int> list in inputList)
        {
            maxIntList.Add(GetHighestValueInList(list));
        }

        return maxIntList;
    }

    static void Main(string[] args)
    {
        List<List<int>> testList = new List<List<int>>();
        testList.Add(new List<int> { 1, 5, 3 });
        testList.Add(new List<int> { 9, 7, 3, -2 });
        testList.Add(new List<int> { 2, 1, 2 });

        
        List<int> maxList = MaxNumbersInLists(testList);
        for (int i = 0; i < maxList.Count; i++)
        {
            Console.WriteLine($"List {i+1} has a maximum number of: {maxList[i]}");
        }
        
    }

}