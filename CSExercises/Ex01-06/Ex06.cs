using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please type integer, I will show your square of that number, Quickly");
            double num = double.Parse(Console.ReadLine());
            num = Math.Sqrt(num);
            Console.WriteLine("Your result is "+ num);
        }
    }
}
