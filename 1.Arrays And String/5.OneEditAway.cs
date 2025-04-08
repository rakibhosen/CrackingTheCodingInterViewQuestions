using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace MyApp
{
    class Program
    {
        static bool OneEditAway(string str1,string str2)
        {
            if (Math.Abs(str1.Length - str2.Length) > 1) return false;

            string s1 = str1.Length <str2.Length ? str1 : str2;
            string s2 = str2.Length < str2.Length ? str2 : str1;

            bool isDiffrence = false ;
            int i = 0, j = 0;
            while (i < s1.Length && j < s2.Length) { 
              if( s1[i] != s2[j]) {
                    if (isDiffrence)
                    {
                        return false;
                    } 
                    else 
                    { 
                        isDiffrence = true; 
                    }

                    if (s1.Length == s2.Length)
                    {
                        i++;
                    }
                  
                }
                else
                {
                    i++;
                }
                j++;
            }

            return true;


        }

        static void Main()
        {
            Console.WriteLine(OneEditAway("pale", "ple"));    //true
            Console.WriteLine(OneEditAway("pales", "pale")); //true
            Console.WriteLine(OneEditAway("pale", "bale")); //true
            Console.WriteLine(OneEditAway("pale", "bake")); //false


        }
    }

}