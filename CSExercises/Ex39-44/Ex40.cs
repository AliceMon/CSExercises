using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            SQT(int.Parse(Console.ReadLine()));
        }

        public static double SQT(int y)
        {
            double x = new Random().NextDouble();
            x = x * (y - 1);
            x = x + 1;
            double G = x;
            bool result;
            do
            {
                result = Math.Abs((G * G) - y) < 0.00001; ;

                if (result == false)
                {
                    G = (G + (y) / G) / 2;
                }
            } while (result == false);
            Console.WriteLine("{0:0.00000}", G);
            return 0;
        }
    }
}