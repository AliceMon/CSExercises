using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] month = new int[12];
            int max=0;
            int min=0;
            int total = 0;
       
            total = total + month[0];
            for (int i=0; i<12; i++)
            {
                System.Console.WriteLine("Enter sales for momth " + i +":");
                month[i] = int.Parse(Console.ReadLine());
                int temp = month[i];
                if (min == 0)
                    min = month[0];
                total = total + month[i];
                if (min > temp)
                {  
                    min = temp;
                }
                else if (max < temp)
                {
                    max = temp;
                }
            }
            System.Console.WriteLine("Maximum sales: {0}", max);
            System.Console.WriteLine("Minimum sales: {0}", min);
            System.Console.WriteLine("Average sales: {0}", total/12);
        }
          
    }
}
