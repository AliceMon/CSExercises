using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            for (int num = 1; num <= 1000; num++)
            {
                int i = 1, sum = 0;
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
            }
        }
    }
}
