using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            for(int x=-5; x<6; x++)
            {
                double y = 2 * x * x - 4 * x + 3;
                System.Console.WriteLine(x + "\t" + y);
            }
            for (int x = -5; x < 6; x++)
            {
                double y = 2 * x * x - 4 * x + 3;
                for (int j = 0; j < y; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
    }
}
