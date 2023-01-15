
class Program
{
    // Find the elements that appear twice in O(n) time
    static void getDuplicateIntegers(int []array)
    {
        // create a temporary array for storing count values
        int maxVal = array.Max();
        int[] temp = new int[maxVal + 1];

        Console.WriteLine("Repeating elements: ");
        // iterate the array once
        for(int i = 0; i < array.Length; i++)
        {
            // if element is flagged 1 at the same index, print
            if (temp[array[i]] == 1)
            {
                Console.WriteLine($"{array[i]}");
            }
            else
            {
                // else add flag
                temp[array[i]]++;
            }
            
        }
    }

    // Merge two sorted arrays and maintain sort in O(n)
    static int[] mergeArray(int []arrayOne, int []arrayTwo)
    {
        // create new array
        int []result = new int[arrayOne.Length + arrayTwo.Length];

        // indexes of all arrays
        int i = 0;
        int j = 0;
        int k = 0;

        // while loop through array until one of the arrays is less than their respective length
        while (i < arrayOne.Length && j < arrayTwo.Length) { 

            // if index of i is less than index of j
            // index of result is assigned to the current index value of i
            if (arrayOne[i] <= arrayTwo[j])
            {
                result[k] = arrayOne[i];
                i++;
            } else
            {
                // otherwise index of result is assigned to the index value of j
                result[k] = arrayTwo[j];
                j++;
            }
            k++;
        }

        // there may be remaining elements after the above while loop terminates
        // in which, we check each individual array for remaining elements buy using
        // the remaining indecies

        // in this specific example, the above while will terminate when i reaches index 4
        // leaving index j 5 and 6 of arrayTwo
        while (i < arrayOne.Length)
        {
            result[k] = arrayOne[i];
            i++;
            k++;
        }

        // j is still at index 4, which is less than arrayTwo.Length, so we continue 
        while (j < arrayTwo.Length)
        {
            result[k] = arrayTwo[j];
            j++;
            k++;
        }

        return result;
    }

    // Given an integer, reverse the digits of that integer
    static int reverseIntegerDigits(int value)
    {
        // convert int to array
        // new array to store

        // iterate backwards
        for (int i = array.Length; i-- > 0;)
        {

        }

        // convert temp array to integer
        // return integer
    }

    static void Main(string[] args)
    {
        int[] duplicatesArray = { 4, 3, 2, 7, 8, 13, 17, 20, 12, 20, 2, 3, 1 };
        getDuplicateIntegers(duplicatesArray);

        int[] mergeArrayOne = { 1, 2, 3, 4, 5 };
        int[] mergeArrayTwo = { 2, 5, 7, 9, 13, 16, 19 };
        int[] mergedSortedArray = mergeArray(mergeArrayOne, mergeArrayTwo);
        Console.WriteLine($"Merged sorted array is: {string.Join(" ", mergedSortedArray)}");
    }
}