using System.Text;

namespace Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var merged = MergeAlternately(word1: "abcd", word2: "pq");
            Console.WriteLine(merged);
        }

        public static string MergeAlternately(string word1, string word2)
        {
            var merged = new StringBuilder();

            for (int i = 0; i < word1.Length; i++)
            {
                merged.Append(word1[i]);

                if (i < word2.Length)
                    merged.Append(word2[i]);
            }

            if (word1.Length < word2.Length)
            {
                var spare = word2.Length - (word2.Length - word1.Length);
                for (int i = spare; i < word2.Length; i++)
                {
                    merged.Append(word2[i]);
                }
            }
            
            return merged.ToString();
        }
    }
}
