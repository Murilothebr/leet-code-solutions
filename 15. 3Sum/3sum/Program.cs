using System.Text;

namespace Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teste = ThreeSum([-1, 0, 1, 2, -1, -4]);
            Console.WriteLine(teste);
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();

            var numsList = nums.ToList();

            int left = 0;
            int right = 0; 
            while (numsList.Count > 3)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (numsList[0] + numsList[i] + numsList[i + 1] == 0)
                    {
                        list.Add(new
                            List<int>([
                                    numsList[0],
                                    numsList[i],
                                    numsList[i + 1]]));
                    }
                }
            }

            return list;
        }
    }
}
