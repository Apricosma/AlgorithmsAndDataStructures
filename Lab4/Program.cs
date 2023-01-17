using System;


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
        // returns a brand new list with a single value from each list
        // O(n) 
        return maxIntList;
    }

    static String HighestGrade(List<List<int>> inputList)
    {
        List<int> maxGrades = MaxNumbersInLists(inputList);
        Console.WriteLine(String.Join(", ", maxGrades));
        int index = maxGrades.IndexOf(maxGrades.Max()) + 1;
        
        string outputString = $"The highest grade is: {maxGrades.Max().ToString()} it was found in class: {index}";
       
        // O(n)
        return outputString;
    }

    // order a list of integers from least to greatest using only basic control statements
    static List<int> OrderByLooping(List<int> list)
    {
        /*
         * bool isSorted;
         * 
         * check if the list is sorted to begin with?
         * for (i = 1; i < list.Count; i++ {
         *     if ( previous > current )
         *          false
         * }
         * 
         * while (!isSorted) 
         * {
         *      for (int i = 0; i < list.Count; i++ {
         *      
         *          for (int j = 0; j < list.Count - i; j++ {
         *              
         *              if ( current > next ) { 
         *                  swap
         *              }  
         *          }
         *      }
         * }
         */

        
        return list;
    }

    static void Main(string[] args)
    {
        List<List<int>> testList = new List<List<int>>
        {
            new List<int> { 1, 5, 3 },
            new List<int> { 9, 7, 3, -2 },
            new List<int> { 2, 1, 2 }
        };


        List<int> maxList = MaxNumbersInLists(testList);
        for (int i = 0; i < maxList.Count; i++)
        {
            Console.WriteLine($"List {i+1} has a maximum number of: {maxList[i]}");
        }

        List<List<int>> grades = new List<List<int>>
        {
            new List<int> { 85, 92, 67, 94, 94 },
            new List<int> { 50, 60, 57, 95 },
            new List<int> { 95 }
        };

        Console.WriteLine(HighestGrade(grades));

        List<int> loopList = new List<int> { 6, -2, 5, 3 };
        Console.WriteLine(string.Join(", ", OrderByLooping(loopList)));
    }

}