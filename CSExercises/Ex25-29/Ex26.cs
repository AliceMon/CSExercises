using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double inverse, sqrt, square;
            System.Console.WriteLine(" No \t Inverse \t SquareRoot \t Square");
            for (int i = 1; i < 11; i++)
            {
                inverse = 1 / i;
                sqrt = Math.Sqrt(i);
                square = i * i;
                System.Console.WriteLine( i + " \t " + inverse + " \t " + sqrt + " \t " + square);
            }
        }
    }
}
