using System;

namespace RemoveDuplicates
{
    public class Program
    {
        public static void Main()
        {
             int [] arr = new int[] {3,1,2,3,4,3,4,5,5,6};
             RemoveDuplicate(arr);
        }
        public static int[] RemoveDuplicate(int[] inputArray)
        {
            // Initialize an empty list
            List<int> numbers = new List<int>();
            foreach (var item in inputArray)
            {

                if (numbers.Contains(item))
                {

                }
                else
                {
                    numbers.Add(item);
                }
            }
            // Output the list
           
             int [] newArr =  numbers.ToArray();
             Array.Sort(newArr);
             Console.WriteLine(string.Join(", ", newArr));
              return newArr;
        }
    }
}