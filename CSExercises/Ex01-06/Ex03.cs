using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi! Please type double precision, I will show your square of that number, Quickly");
            double num = Double.Parse(Console.ReadLine());
            Console.WriteLine("Your result is" + num * num);
        }
    }
}
