using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {   //25(a)
           /* int num, result;
            System.Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            result= num;
            for(int i=1; i < num ; i++)
            {
                result = result * i;
            }
            System.Console.WriteLine(result);*/


            ////////////////////////////////////////

            //25(b)
            int num, result;
            System.Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            result = num;
            for (int i = num-1; i > 0; i--)
            {
                result = result * i;
            }
            System.Console.WriteLine(result);


        }
    }
}
