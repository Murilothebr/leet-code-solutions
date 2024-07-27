using System.Text;
using System.Text.RegularExpressions;

namespace Two_Sum;

internal class Program
{
    static void Main(string[] args)
    {
        var s = "race a car";

        var a = IsPalindrome(s);

        Console.WriteLine(a);
    }

    public static bool IsPalindrome(string s)
    {
        if(s.Equals(""))
            return true;
        
        s = s.ToLower().Replace(" ", "");

        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");

        var regularChar = s.ToCharArray();
        var inverse = regularChar.Reverse().ToArray();

        return regularChar.SequenceEqual(inverse);
    }
}
    