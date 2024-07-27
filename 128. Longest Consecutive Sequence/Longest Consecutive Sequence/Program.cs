namespace Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };

        var a = LongestConsecutive(nums);

        Console.WriteLine(a);
    }

    public static int LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0) 
            return 0;

        List<int> ints = new List<int>(nums); 
        int minor = nums.Min();
        int count = 1;

        while (true)
        {
            if (nums.Contains(minor + 1) || nums.Contains(minor)) 
            {
                count += 1;
                minor += 1;

                ints.Remove(minor);

                continue;
            }

            break;
        }

        return count;
    }
}
    