// Reverse a string

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Questions
{
    public class Program
    {
        public static void Main()
        {
            // using normal string
            reseverString("Vishal Chaudhary");
            Console.WriteLine();

            // using stringBuilder
           string s = ReverseStringByBuilder("Vishal Chaudhary Builder");
           Console.WriteLine("--------------");
           Console.Write(s);
            Console.WriteLine("--------------");
             Console.WriteLine();
          string str =   LinqReverseString("Vishal Chaudhary");
          Console.Write(str);
        }

        public static string reseverString(string str)
        {
           if(str == null) return string.Empty;

            string reverse = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
                reverse +=str[i];
            }
            return reverse;
        }
        // Using stringBuilder for better optimization

        public static string ReverseStringByBuilder(string str){
            if(str == null) return string.Empty; // Return empty string instead of null; // handles input
            StringBuilder reverse = new StringBuilder();
            for(int i = str.Length-1; i>=0; i--){
                reverse.Append(str[i]);
            }
            return reverse.ToString();
        }
       // using LINQ
        public static string LinqReverseString(string str){
            if(str == null) return string.Empty;
            
            return new string(str.Reverse().ToArray());
        }
    }
}

