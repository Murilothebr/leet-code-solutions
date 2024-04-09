namespace Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 2, 4 };

        var x = TwoSum(nums, 6);
        Console.WriteLine(x);
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        var arr = new int[2]{ 0 , 0 };

        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    arr[0] = i;
                    arr[1] = j;
                    return arr;
                }
            }
        
        return arr;
    }
}
