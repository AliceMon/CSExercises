using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int i = 1, sum = 0;
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
                i++;
            }

            if (sum == num)
                Console.WriteLine("{0} is a Perfect Number", i);
            else
                Console.WriteLine("{0} is not Perfect Number", i);
        }
    }
}
