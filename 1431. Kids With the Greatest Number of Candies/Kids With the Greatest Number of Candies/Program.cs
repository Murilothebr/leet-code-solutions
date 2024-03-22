namespace Kids_With_the_Greatest_Number_of_Candies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 1, 3 };

            var x = KidsWithCandies(arr, 3);
            Console.WriteLine(x);
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var listIfGreatest = new List<bool>();
            var mostAmoutOfCandies = 0;

            foreach (var candieAmount in candies)
            {
                if (candieAmount > mostAmoutOfCandies)
                    mostAmoutOfCandies = candieAmount;
            }

            foreach (var candieAmount in candies)
                listIfGreatest.Add(candieAmount + extraCandies >= mostAmoutOfCandies);

            return listIfGreatest;
        }
    }
}
