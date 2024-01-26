using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 4, 3, 2, 1, 0 };
        printArray(sortedSquares(array));
    }
    public static int[] sortedSquares(int[] array)
    {
        int[] newArray = new int[array.Length];
        int voidBox = 0;
        for (int e = 0; e < array.Length; e++)
        {
            newArray[e] = array[e] * array[e];
        }
        for (int i = 0; i < newArray.Length; i++)
        {
            for (int j = 0; j < newArray.Length - (1 + i); j++)
            {
                if (newArray[j] > newArray[j + 1])
                {
                    voidBox = newArray[j + 1];
                    newArray[j + 1] = newArray[j];
                    newArray[j] = voidBox;
                }
            }
        }
        return newArray;
    }
    public static void printArray(int[] array)
    {
        foreach (int number in array)
        {
            System.Console.Write(number + " ");
        }
    }
}
