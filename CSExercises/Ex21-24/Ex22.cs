using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of B: ");
            int B = int.Parse(Console.ReadLine());
            int C = A * B;
            do
            {
                if (A > B)
                {
                    A = A - B;
                }
                else if (B > A)
                {
                    B = B - A;
                }
            } while (A != B);
            Console.WriteLine("X");
            int HCF = A;
            int LCM = C / HCF;
            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: " + LCM);
        }
    }
}
