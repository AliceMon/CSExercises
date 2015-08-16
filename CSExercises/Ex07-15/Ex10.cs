using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double[] i = new double[4];
            double distance;
            System.Console.WriteLine("Enter x1, y1 ,x2, y2 in order:");
            for(int j = 0; j <4; j++)
            {
               i[j] = Double.Parse(Console.ReadLine());
            }
            distance = Math.Sqrt((i[2] - i[0]) * (i[2] - i[0]) + (i[3] - i[1]) * (i[3] - i[1]));
            Console.WriteLine("The distance is:" + distance);
        }
    }
}
