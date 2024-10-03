


namespace square
{
    public class Program
    {
        public static void Main()
        {
            square(9);
        }

        public static void square(int n)
        {
            if(n>0)
            {
                int k = n*n;
                Console.Write(k +" ");
                square(n-1);
            
            }
        }
    }
}
