

namespace Digits
{
    public class Program
    {
        public static void Main()
        {
              int num = 12345;
              sumofdigits(num);
        }
        public static void sumofdigits(int n) // 1234
        {

            int sum = 0;

            string s = Convert.ToString(n);

            for (int i = 0; i < s.Length; i++)
            {

                if (int.TryParse(s[i].ToString(), out int digit))
                {
                    sum += digit; // Add the digit to the sum
                }
            }
            Console.WriteLine(sum);
        }
    }
}