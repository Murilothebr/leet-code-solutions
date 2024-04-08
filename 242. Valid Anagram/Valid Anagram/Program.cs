namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = IsAnagram(s: "anagram", t: "nagaram");
            Console.WriteLine(x);
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            return SortString(s) == SortString(t);
        }

        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
