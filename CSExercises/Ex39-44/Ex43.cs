using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
               Console.WriteLine(String.Format("0x{0:X}", i));
            }
            Console.WriteLine("enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Hex(num));
        }
        public static string Hex(int i)
        {
            char[] ch = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            if(i<10)
            {
                return i.ToString();
            }
            else if (i%10<6)
            {
                if (i / 10 > 1)
                {
                    return "" + ((i / 10) - 1) + "" + ch[i % 10];
                }
                else
                {
                    return "" + ch[i % 10];
                }
            }
            else if(i%16==0)
            {
                Console.WriteLine(i / 16 + "0");
            }
            else if (i%16>0)
            {
                return""+ i / 16+""+ i % 16;
            }
            return null;
        }
    }
}
