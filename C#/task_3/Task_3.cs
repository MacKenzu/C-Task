class Task_3
{
    static void Main(string[] args)
    {
        int[] array1 = new int[] { 3, 4, 5, 0, 0, 0 };
        int[] array2 = new int[] { 1, 2, 3 };
        int m = 3;
        int n = 3;
        mergeArray(array1, m, array2, n);
        printArray(array1);
    }
    public static void printArray(int[] array)
    {
        foreach (int num in array)
        {
            System.Console.Write(num + " ");
        }
    }
 public static void MergeArrays(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1; // last element in nums1
    int j = n - 1; // last element in nums2
    int k = m + n - 1; // index for writing into nums1

    while (i >= 0 && j >= 0)
    {
        if (nums1[i] > nums2[j])
        {
            nums1[k--] = nums1[i--];
        }
        else
        {
            nums1[k--] = nums2[j--];
        }
    }

    while (j >= 0)
    {
        nums1[k--] = nums2[j--];
    }
}


}
