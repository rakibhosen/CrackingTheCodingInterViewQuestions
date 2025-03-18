using System;
using System.Xml.Linq;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Check wheather its contain unique character or not
            string name = "hello";
            Console.WriteLine(isUnique(name));


        }


        public static bool isUnique(string name) {
            HashSet<char> charString = new HashSet<char>();
            bool flag= false;   
            foreach (char c in name) {
                if(charString.Contains(c)) return flag= false;
                charString.Add(c);
                flag = true;
            }
            return flag;
        }
    }
}