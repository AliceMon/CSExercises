using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string EnterString;
            System.Console.Write("Please enter a phrase: ");
            EnterString = Console.ReadLine();
            char ch1 = 'a';
            char ch2 = 'e';
            char ch3 = 'i';
            char ch4 = 'o';
            char ch5 = 'u';

            int counta = 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;

            char ch6 = 'A';
            char ch7 = 'E';
            char ch8 = 'I';
            char ch9 = 'O';
            char ch10 = 'U';

            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;

            int j = counta + counte + counti + counto + countu + countA + countE + countI + countO + countU;
           

            foreach (char v in EnterString)
            {
                if (v == ch1) { counta++; j++; }

                else if (v == ch2) { counte++; j++; }

                else if (v == ch3) { counti++; j++; }

                else if (v == ch4) { counto++; j++; }

                else if (v == ch5) { countu++; j++; }
            }
            foreach (char v in EnterString)
            {
                if (v == ch6) { countA++; j++; }

                else if (v == ch7) { countE++; j++; }

                else if (v == ch8) { countI++; j++; }

                else if (v == ch9) { countO++; j++; }

                else if (v == ch10) { countU++; j++; }
            }

            int a = counta + countA;
            int e = counte + countE;
            int i = counti + countI;
            int o = counto + countO;
            int u = countu + countU;

            System.Console.WriteLine("Total numbers of vowel: " +j);
            System.Console.WriteLine(" numbers of a: " + a);
            System.Console.WriteLine(" numbers of e: " + e);
            System.Console.WriteLine(" numbers of i: " + i);
            System.Console.WriteLine(" numbers of o: " + o);
            System.Console.WriteLine(" numbers of u: " + u);
        }
    }
}
