
class Program
{
    // Find the elements that appear twice in O(n) time
    static void getDuplicateIntegers(int []array)
    {
        // create a temporary array for storing count values
        int maxVal = array.Max();
        int[] temp = new int[maxVal + 1];

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

    
    static void Main(string[] args)
    {
        int[] myArray = { 4, 3, 2, 7, 8, 13, 17, 20, 12, 20, 2, 3, 1 };
        getDuplicateIntegers(myArray);
    }
}