using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num, num1;
            bool equal = false;
            num1 = 88;
            while(!equal)
            {
                System.Console.WriteLine("Enter your number: ");
                num = int.Parse(Console.ReadLine());
                
                if (num == num1)
                {
                    Console.Write("Lucky you..... :)");
                    equal = true;
                }
                else
                {
                    Console.Write("try again!!!!");
                }
            }
        }
    }
}
