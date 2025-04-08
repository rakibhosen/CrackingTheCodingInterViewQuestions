using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MyApp
{
    class Program
    {
        static string   StringCompression(string str)
        {

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str) {
                if (charCount.ContainsKey(c)) {
                    charCount[c]++;

                }
                else
                {
                    charCount[c] = 1;
                }
            }
            var newStr = new StringBuilder();

            foreach (var chcount in charCount) { 

                newStr.Append(chcount.Value.ToString());
                newStr.Append(chcount.Key.ToString());


            }
            return newStr.Length > str.Length ? str : newStr.ToString();
        }

        static void Main()
        {
            Console.WriteLine(StringCompression("aabbbbccceeeeea"));//3a4b3c5e
            Console.WriteLine(StringCompression("abc"));//abc

        }
    }

}