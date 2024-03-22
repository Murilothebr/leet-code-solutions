using System.Text;

namespace Greatest_Common_Divisor_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var x = GcdOfStrings("ABABAB", "ABAB");
            //var x = GcdOfStrings("ABCDEF", "ABC");
            var x = GcdOfStrings("CTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXK", "CTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXKCTCXK");

            Console.WriteLine(x);
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            var GcdStg = "";

            var smallerLenght = str1.Length;

            if (str2.Length < str1.Length)
                smallerLenght = str2.Length;

            for (int i = 1; i <= smallerLenght; i++)
            {
                var slice1 = str1.Substring(0, i);
                var slice2 = str2.Substring(0, i);

                if (! slice1.Equals(slice2))
                    continue;

                if(! (isStringCompatible(str1: str1, str2: str2, index: i) && isStringCompatible(str1: str2, str2: slice1, index: i)))
                    continue;

                if (( str2.Contains(str1.Substring(i)) || str1.Contains(str2.Substring(i)) ) && ( str1.Contains(str2) || str2.Contains(str1) ))
                    GcdStg = slice1;
            }

            return GcdStg;
        }

        public static bool isStringCompatible(string str1, string str2, int index) =>
            str1.Length % str2.Substring(0, index).Length == 0;
    }
}
