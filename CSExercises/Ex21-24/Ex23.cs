
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises

{
    public class Ex23
    {
        public static void Main(string[] args)
        {   
            //23(a)
            /*Random rnd = new Random();
            int num, num1, count = 0;
            bool equal = false;
            num1 = rnd.Next(0, 10);
            while (!equal)
            {
                System.Console.WriteLine("Enter your number: ");
                num = int.Parse(Console.ReadLine());
                count++;
                if (num == num1)
                {   
                    Console.Write("Genius!!! your take {0} times to guess" , count);
                    equal = true;
                }
                else
                {
                    Console.Write("try again!!!!");
                 
                }
            }*/

            //////////////////////////////////
            
            //23(b)
            Random rnd = new Random();
            int num, num1, count = 0;
            bool equal = false;
            num1 = rnd.Next(0, 10);
            while (!equal)
            {
                System.Console.WriteLine("Enter your number: ");
                num = int.Parse(Console.ReadLine());
                count++;
                if (num == num1)
                {   
                    if (count <=2)
                    {
                        Console.Write("You are a Wizard!");
                    }
                    else if(count == 3)
                    {
                        Console.Write("You are a good guess!");
                    }
                    else
                    {
                        Console.Write("You are lousy!");
                    }
                    equal = true;
                }
                else
                {
                    Console.Write("try again!!!!");

                }
            }
        }
    }
}
