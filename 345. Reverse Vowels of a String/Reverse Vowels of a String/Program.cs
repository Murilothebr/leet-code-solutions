using System.Text;

namespace Reverse_Vowels_of_a_String;

internal class Program
{
    static void Main(string[] args)
    {
        var x = ReverseVowels("race car");

        Console.WriteLine(x);
    }

    public static string ReverseVowels(string s)
    {
        StringBuilder reversed = new StringBuilder(s);
        List<int> voelIndexs = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (isVoel(s[i]))
                voelIndexs.Add(i);
        }

        if (voelIndexs.Count < 2)
            return s;

        var count = voelIndexs.Count -1;
        for (int i = 0; i < voelIndexs.Count; i++)
        {
            reversed[voelIndexs[i]] = s[voelIndexs[count]];
            count--;
        }

        return reversed.ToString();
    }

    public static bool isVoel(char ch)
    {
        char[] voewls = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        if (!voewls.Contains(ch))
            return false;

        return true;
    }
}
