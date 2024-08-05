using System.Text;

namespace Reverse_Words_in_a_String;

internal class Program
{
    static void Main(string[] args)
    {
        var number = TwoSum([2, 7, 11, 15], 9);

        Console.WriteLine(number);
    }

    public static int[] TwoSum(int[] numbers, int target)
    {
        var answer = new int[2];

        var left = 0;
        var right = numbers.Length - 1;
        var mid = right / 2;

        if (numbers[0] + numbers[mid] > target )
        {
            right = mid;
        }

        while (left < right)
        {
            var copy = right;
            while (left < copy)
            {
                if (numbers[left] + numbers[copy] == target)
                {
                    answer[0] = left + 1;
                    answer[1] = copy + 1;
                }

                copy--;
            }

            left++;
        }

        return answer;
    }
}
