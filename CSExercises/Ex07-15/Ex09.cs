using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            float x, y;
            Console.Write("Enter the value of x: ");
            x = float.Parse(Console.ReadLine());
            y = 2 * x * x - (4 * x) + 3;
            Console.WriteLine("The value of y: " + y);
        }
    }
}
