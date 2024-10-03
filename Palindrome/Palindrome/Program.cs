using System;
using System.Text;

namespace Palindrome{

    public class Program {
        public static void Main(){
          
          string str = "Vishal";
          string reverse = Reverse(str);
          // Check if the original and reversed strings are the same, ignoring case
            if (string.Equals(str, reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Great! The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }

        }
        public static string Reverse (string str) {

            if(str == null) return string.Empty;
            StringBuilder reverse = new StringBuilder();
             
             for( int i = str.Length -1; i>=0; i--){
                reverse.Append(str[i]);
             }
             return reverse.ToString();
        }
    }
}