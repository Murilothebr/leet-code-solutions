namespace Richest_Customer_Wealth;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];
        arr[0] = new int[3];
        arr[1] = new int[3];
        arr[2] = new int[3];


        arr[0] = [1, 5];
        arr[1] = [3, 5];
        arr[2] = [7, 3];

        var max = MaximumWealth(arr);

        Console.WriteLine("Hello, World!");
    }


    public static int MaximumWealth(int[][] accounts)
    {
        int maxValue = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > maxValue)
            {
                maxValue = sum;
            }
        }

        return maxValue;
    }
}
