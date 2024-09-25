namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return  x + y;
        }

        public static decimal  Add(decimal a, decimal b)
        {
            return  a + b;
        }

        public static string Add(int c, int d, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue == true)
            {
                sum = c + d;

                if (sum == 1)
                {
                    return  $"{sum} dollar";
                }
                else
                {
                    return  $"{sum} dollars";
                }
                
                
            }

            return response;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 0, true));
            
            Console.WriteLine();
            
            Console.WriteLine(Add(1, 2, true));
            
            Console.WriteLine();
            
            Console.WriteLine(Add(-3, -4, true));
        }
    }
}
