using System;
using System.Xml.Linq;

namespace MyApp
{
    class Program
    {
        static bool CheckPermutation(string str1, string str2)
        {
            if (str1.Length!=str2.Length) return false;
            int[] countCharacter = new int[128];

            foreach (char c in str1) countCharacter[c]++;
            foreach(char c in str2)
            {
                countCharacter[c]--;
                if (countCharacter[c] < 0)
                    return false;
            }
            return true;

        }

        static void Main()
        {
            Console.WriteLine(CheckPermutation("abc", "bca")); // True
            Console.WriteLine(CheckPermutation("abc", "xyz")); // False
        }
    }

}