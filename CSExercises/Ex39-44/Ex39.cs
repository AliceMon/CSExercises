using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            long x = long.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }

        public static long Factorial(long n)
        {
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                temp = temp * i;
            }
            return temp;
        }
    }
}
