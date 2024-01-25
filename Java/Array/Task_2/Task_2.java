//Дан массив nums целых чисел. Определите, сколько из них содержат четное количество цифр.
package Task_2;

public class Task_2 {
    public static void main(String[] args) {
        int[] num = new int[]{0, 12, 2, 124, 23, 1, 23};
        System.out.println(findNumbers(num));
    }

    public static int findNumbers(int[] nums) {
        int count = 0;
        int countNumb = 0;
        for (int i = 0; i < nums.length; i++) {
            do {
                nums[i] /= 10;
                count++;
            }
            while (nums[i] > 0);
            if ((count % 2) == 0)
                countNumb++;
            count = 0;
        }
        return countNumb;

    }
}
