using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double distance, dist ,totalcharge;
            System.Console.WriteLine("Enter your kilometres travelled: ");
            distance = double.Parse(System.Console.ReadLine());
            distance = Math.Ceiling(distance * 10); // change to meter from kilometer
            System.Console.WriteLine(distance);
            if(distance > 90)
            {
                dist = distance - 90;
                totalcharge = 2.4 + (85 * 0.04) + (dist * 0.05);
            }
            else if (distance > 5)
            {
                totalcharge = 2.4 + (distance * 0.04);
            }
            else
            {
                totalcharge = 2.4;
            }
            System.Console.WriteLine("Total charge: " + totalcharge );
        }
    }
}