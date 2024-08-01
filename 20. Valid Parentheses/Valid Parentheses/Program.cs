using System.Linq;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsValid("([]{})"));
    }

    public static bool IsValid(string s)
    {
        if (s.Length % 2 == 1)
            return false;

        var chars = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            if(i == s.Length -1)
                continue;

            if (chars[i + 1] == chars[i] + 1 || chars[i] == chars[i + 1] || chars[i + 2] == chars[i] + 2)
            {
                i++;
                continue;
            }

            return false;
        }

        return true;
    }
}
