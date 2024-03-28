using System.Text;

namespace Reverse_Words_in_a_String;

internal class Program
{
    static void Main(string[] args)
    {
        var x = ReverseWords("a good   example");


        Console.WriteLine(x);
    }

    public static string ReverseWords(string s)
    {
        List<string> chunk = new List<string>();
        string reverted = "";

        foreach (string s2 in s.Split(" "))
        {
            if(s2 != "")
                chunk.Add(s2);
        }

        for (int i = chunk.Count - 1; i >= 0; i--)
        {
            reverted += chunk[i] + " ";
        }

        return reverted.Trim();
    }
}
