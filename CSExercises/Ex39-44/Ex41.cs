using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string first, second;
            Console.WriteLine("enter first string: ");
            first = Console.ReadLine();
            Console.WriteLine("enter second string: ");
            second = Console.ReadLine();
            Console.WriteLine(InString(first, second));
        }
        public static bool InString(string s1, string s2)
        {
            int k = 0;
            int count = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                for (int j = k; j < s1.Length; j++)
                {
                    if (s1[j] == s2[i])
                    {
                        k = j + 1;
                        count++;
                        break;
                    }
                }
            }
            if (count == s2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
