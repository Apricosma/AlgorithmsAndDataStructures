// Find the elements that appear twice in O(n) time

using System.Drawing;

class Program
{
    static void printRepeating(int[] arr, int size)
    {
        int[] count = new int[size];
        int i;

        Console.Write("Repeating elements are ");
        for (i = 0; i < size; i++)
        {
            if (count[arr[i]] == 1)
                Console.Write(arr[i] + " ");
            else
                count[arr[i]]++;
        }
    }

    // driver code
    public static void Main()
    {
        int[] arr = { 4, 2, 4, 5, 2, 3, 1 };
        int arr_size = arr.Length;

        printRepeating(arr, arr_size);
    }

}