using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not Prime");
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " is not Prime");
                        return;
                    }
                }
                Console.WriteLine(num + " is Prime");
            }
        }
    }
}
