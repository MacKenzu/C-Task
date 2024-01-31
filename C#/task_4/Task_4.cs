class Task_3
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 2, 3, 4, 4, 3, 3, 2, 2 };
        int num = 2;
        printArray(array);
        System.Console.WriteLine();
        System.Console.WriteLine(RemoveElement(array, num));
        printArray(array);
    }
    public static void printArray(int[] arr)
    {
        System.Console.Write("[");
        foreach (int num in arr)
        {
            System.Console.Write(num + ", ");
        }
        System.Console.Write("]");
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count++] = nums[i];
            }
        }
        return count;
    }
}

