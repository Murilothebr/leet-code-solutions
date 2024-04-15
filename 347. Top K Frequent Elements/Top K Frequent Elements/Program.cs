using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 2, 3, 3, 3, 3 };
            var k = 2;

            var v = TopKFrequent(x, k);
            Console.WriteLine("Hello, World!");
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            HashSet<int> visited = new HashSet<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>(2);
            int[] arr = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                visited.Add(nums[i]);
            }

            foreach (int i in visited)
            {
                dic.Add(i, 0);
            }

            foreach (int i in nums)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
            }

            dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            for (int i = 0 ; i < arr.Length; i++)
            {
                arr[i] = dic.ElementAt(i).Key;
            }

            return arr;
        }
    }
}
