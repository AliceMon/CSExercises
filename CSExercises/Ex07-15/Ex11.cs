using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double distance, totalFare;
            System.Console.Write("Enter your distance travel: ");
            distance = double.Parse(Console.ReadLine());
            totalFare = 2.40 + (distance * 0.4);
            Console.WriteLine("Your total fare is: {0}", totalFare);
        }
    }
}
