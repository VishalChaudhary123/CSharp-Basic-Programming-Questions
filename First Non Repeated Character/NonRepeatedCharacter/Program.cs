using System;

namespace NonRepeatedCharacter
{
    public class Program
    {
        public static void Main()
        {
            string result = FirstNonRepeatedCharacter("swiss");
            Console.WriteLine(result); // Output the result
        }
        public static string FirstNonRepeatedCharacter(string str)
        {

            // Dictionary to count occurrences of each character
            Dictionary<char, int> charCount = new Dictionary<char, int>();


            // First pass: count the occurrences of each character
            foreach (char ch in str)
            {

                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount[ch] = 1;
                }
            }
             // Second pass: find the first non-repeated character
             foreach (char ch in str)
            {
                if (charCount[ch] == 1)
                {
                    return ch.ToString(); // Return the first non-repeated character
                }
            }

            return string.Empty; // Return null if no non-repeated character is found

        }
    }
}