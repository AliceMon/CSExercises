using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            double money = 0;
            Console.Write("Enter your money,I think your gud user :): ");
            money = double.Parse(Console.ReadLine());
            
            int[] coin = new int[] { 100, 50, 20, 10, 5 };
            double[] count = new double[] {0,0,0,0,0};
            money = money * 100;
            if(money/100 > 0)
            {
                count[0] = money / 100;
            }
            if ((money % 100)/50 > 0)
            {
                count[1] = (money % 100) / 50;
            }
            if (((money % 100) % 50)/20 > 0)
            {
                count[2] = ((money % 100) % 50) / 20;
            }
            if ((((money % 100) % 50) % 20)/10 > 0)
            {
                count[3] = (((money % 100) % 50) % 20) / 10;
            }
            if (((((money % 100) % 50) % 20) % 10)/5 > 0)
            {
                count[4] = ((((money % 100) % 50) % 20) % 10) / 5;
            }
            for (int i =0;i<5;i++)
            {
                for(int j=0;j<Math.Floor(count[i]);j++)
                {
                    Console.WriteLine(coin[i]);
                }
               
            }
        }
    }
}
