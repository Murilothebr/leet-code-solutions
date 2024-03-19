namespace _1480._Running_Sum_of_1d_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 10, 1 };

            var newArr = RunningSum(nums);
        }

        public static int[] RunningSum(int[] nums)
        {
            int i = 1;
            while (i < nums.Length)
            {
                nums[i] = nums[i] + nums[i - 1];
                i += 1;
            }

            return nums;
        }
    }
}
 