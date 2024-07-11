using System;

namespace Product_of_Array_Except_Self;

internal class Program
{
    static void Main(string[] args)
    {
        int[] x = { -1, 1, 0, -3, 3 };

        var y = ProductExceptSelf(x);

        Console.WriteLine("Hello, World!");
    }
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = result[i] * nums[i];
        }
        
        return result;
    }
}
