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
            Console.WriteLine("NO \t INVERSE \t SQUARE ROOT \t SQUARE");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0:#.0} \t ", i);
                Console.Write("{0:0.0##} \t \t ", 1.0 / i);
                Console.Write("{0:#.0##}\t \t ", Math.Sqrt(1.0 * i));
                Console.WriteLine("{0:#.0}", i * i);
            }
        }
    }
}

