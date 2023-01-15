
class Program
{
    // Find the elements that appear twice in O(n) time
    static void getDuplicateIntegers(int []array)
    {
        // create a temporary array for comparison
        int[] temp = new int[array.Length];

        // iterate the array once
        for(int i = 0; i < array.Length; i++)
        {
            // if element is flagged, print
            if (temp[array[i]] == 1)
            {
                Console.WriteLine($"{array[i]}, ");
            }
            else
            {
                temp[array[i]]++;
            }
            // else add flag
        }
    }

    
    static void Main(string[] args)
    {
        int[] myArray = { 4, 3, 2, 7, 8, 2, 3, 1 };
        getDuplicateIntegers(myArray);
    }
}