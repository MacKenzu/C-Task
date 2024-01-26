/*Дублирование нулей в масииве*/

class Task_2
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 0, 0, 2, 3, 2, 5, 0 };
        printArray(array);
        System.Console.WriteLine();
        dublerZero(array);
        printArray(array);

    }
    public static void printArray(int[] arr)
    {
        foreach (int num in arr)
        {
            System.Console.Write(num + " ");
        }
    }
    public static void dublerZero(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0 && i != arr.Length - 1)
            {
                for (int j = arr.Length - 2; j > i; j--)
                {
                    arr[j + 1] = arr[j];

                }
                arr[i + 1] = 0;
                i += 1;
            }
        }
    }
}