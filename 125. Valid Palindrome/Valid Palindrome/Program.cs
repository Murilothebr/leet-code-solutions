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
        if (s.Equals(""))
            return true;

        s = s.ToLower();

        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");


        int left = 0, right = s.Length - 1;

        while (left < right) 
        {
            if (s[left++] != s[right--])
                return false;
        }

        return true;
    }
}
