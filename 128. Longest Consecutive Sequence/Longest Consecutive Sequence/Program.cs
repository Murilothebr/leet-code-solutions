namespace Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };

        Console.WriteLine(LongestConsecutive(nums));
    }

    public static int LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0) 
            return 0;

        List<int> ints = new List<int>(nums);
        int minor = ints.Min();
        int count = 1;

        while (true)
        {
            if (ints.Contains(minor + 1)) 
            {
                count += 1;
                minor += 1;

                continue;
            }

            break;
        }

        return count;
    }
}
    